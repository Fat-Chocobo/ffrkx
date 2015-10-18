using FFRKInspector.Database;
using FFRKInspector.GameData;
using FFRKInspector.GameData.RWs;
using Fiddler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.Proxy
{
    /// <summary>
    /// When first opened the Friends list gets a /dff/relation/followee_and_follower_list response containing for 
    ///     followers and followees both:
    ///         the first 5 'target_profiles' (all the RW stats, gear, etc, & the player name, id, slogan, etc)
    ///         a list of all 'user_relations' (user_id mappings)
    /// As you scroll you get one response of /dff/relation/find_by_user_ids per page with 5 target_profiles and thier related user_relations records
    /// The find_by_user_ids responses do not indicate whether they correspond with followers or followees. That is apparently left up to the app
    /// 
    /// parsing:
    ///     build a DB of followees by userid, leave most of data blank until the user id comes up in a target_profile.
    ///     keep these data points from target_profile
    /// </summary>
    class HandleFollowersAndFollowees : SimpleResponseHandler
    {
        public override bool CanHandle(Session Session)
        {
            string RequestPath = Session.oRequest.headers.RequestPath;
            return RequestPath.Equals("/dff/relation/followee_and_follower_list", StringComparison.CurrentCultureIgnoreCase) //initial response from friends list from Menu
                || RequestPath.Equals("/dff/relation/find_by_user_ids", StringComparison.CurrentCultureIgnoreCase)           //loading next page from friends list OR battle select screen
                || RequestPath.Equals("/dff/relation/detailed_fellow_listing", StringComparison.CurrentCultureIgnoreCase);   //initial response from battle select screen
        }

        public override void Handle(Session Session)
        {
            List<DataRelatedRW> RWs = new List<DataRelatedRW>();
            List<DataRelatedRW> Users = new List<DataRelatedRW>();
            List<DataTargetProfile> Profiles = new List<DataTargetProfile>();

            if (Session.oRequest.headers.RequestPath.Equals("/dff/relation/followee_and_follower_list", StringComparison.CurrentCultureIgnoreCase))
            {   
                //We just opened the friends list. get all the user_relations and the target_profiles rcvd
                DataAllRelations FolloweesFollowers = JsonConvert.DeserializeObject<DataAllRelations>(GetResponseBody(Session));
                
                //List of all user IDs, taking only follower records (status 1) from the followers list (no mutual duplication)
                Users.AddRange(FolloweesFollowers.Followees.Users);
                Users.AddRange(FolloweesFollowers.Followers.Users.Where((rw) => rw.RelationStatus == (byte)DataRelatedRW.Relationship.Follower));

                Profiles.AddRange(FolloweesFollowers.Followees.Profiles);
                Profiles.AddRange(FolloweesFollowers.Followers.Profiles);
            }

            if (Session.oRequest.headers.RequestPath.Equals("/dff/relation/find_by_user_ids", StringComparison.CurrentCultureIgnoreCase))
            {
                //extract the DataRelatedRW records and the target_profiles
                DataRelationPackage RelationsPackage = JsonConvert.DeserializeObject<DataRelationPackage>(GetResponseBody(Session));
                Users.AddRange(RelationsPackage.Users);
                Profiles.AddRange(RelationsPackage.Profiles);
            }

            if (Session.oRequest.headers.RequestPath.Equals("/dff/relation/detailed_fellow_listing", StringComparison.CurrentCultureIgnoreCase))
            {
                //got a fellow listing at the dungeon entrance screen
                DataDungeonFellowListing RelationsPackage = JsonConvert.DeserializeObject<DataDungeonFellowListing>(GetResponseBody(Session));
                foreach (DataTargetProfile DetailedProfile in RelationsPackage.Profiles)
                    Users.Add(new DataRelatedRW(DetailedProfile.UserID, DetailedProfile.RelationStatus).UpdateRWData(DetailedProfile));
            }

            //Merge profile data into user list 
            foreach (DataTargetProfile ProfileData in Profiles)
            {
                DataRelatedRW RW = Users.FirstOrDefault(a => a.UserID == ProfileData.UserID);
                if (RW != null)
                {
                    RW.UpdateRWData(ProfileData);
                }
            }

            //Update existing list of RWs and add new RWs
            List<DataRelatedRW> AllRWs = FFRKProxy.Instance.GameState.RelatedRWs;
            if (AllRWs == null)
            {
                AllRWs = new List<DataRelatedRW>();
            }

            foreach (DataRelatedRW NewRW in Users)
            {
                DataRelatedRW ExistingRW = AllRWs.FirstOrDefault(a => a.UserID == NewRW.UserID);
                if (ExistingRW != null)
                {
                    //Update if we have existing data
                    if (NewRW.SBName != "")
                        ExistingRW.UpdateRWData(NewRW);
                }
                else
                {
                    //Otherwise it's added completely new
                    AllRWs.Add(NewRW);
                }
            }
                
            FFRKProxy.Instance.GameState.RelatedRWs = AllRWs;
            FFRKProxy.Instance.RaiseRWList(AllRWs);
        }
    }
}
