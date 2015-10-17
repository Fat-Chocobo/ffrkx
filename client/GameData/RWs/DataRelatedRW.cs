using FFRKInspector.GameData.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FFRKInspector.GameData.RWs
{
    class DataRelatedRW
    {
        public enum Relationship
        {
            Random,
            Follower,
            Followee,
            Mutual
        };

        //user relation and target profile data combined here.
        //  An array of this is stored in GameState with all followers AND followees, UI to differentiate by relation_status value (1 is follower, 2 is followee, 3 is mutual)

        ///relation_status = 0 is no relation (random options from battle selection), 1 is follower, 2 is followee, 3 is mutual
        [JsonProperty("relation_status")]
        public byte RelationStatus;

        [JsonProperty("target_user_id")]
        public ulong UserID;

        //Fields below this point come from the 'profile' data structures

        ///nickname = player name (for identification in app list)
        [JsonProperty(PropertyName = "nickname", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("")]
        public string NickName;

        ///profile_message = slogan (for identification in app list)
        [JsonProperty(PropertyName = "profile_message", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("")]
        public string Slogan;

        ///supporter_buddy_soul_strike_name = name of the SB
        [JsonProperty(PropertyName = "supporter_buddy_soul_strike_name", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("")]
        public string SBName;

        ///supporter_buddy_soul_strike_type = Uncertain, but may be useful for auto-selecting the primary stat for the SB
        [JsonProperty(PropertyName = "supporter_buddy_soul_strike_type", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 SBType;

        ///supporter_buddy_acc = accuracy
        [JsonProperty(PropertyName = "supporter_buddy_acc", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 Accuracy;

        ///supporter_buddy_atk = attack
        [JsonProperty(PropertyName = "supporter_buddy_atk", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 Attack;

        ///supporter_buddy_matk = magic
        [JsonProperty(PropertyName = "supporter_buddy_matk", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 Magic;

        ///supporter_buddy_mnd = mind
        [JsonProperty(PropertyName = "supporter_buddy_mnd", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 Mind;

        ///supporter_buddy_spd = speed
        [JsonProperty(PropertyName = "supporter_buddy_spd", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public UInt16 Speed;

        public DataRelatedRW(ulong User, byte Relation)
        {
            this.UserID = User;
            this.RelationStatus = Relation;
        }

        public DataRelatedRW UpdateRWData(DataRelatedRW NewRW)
        {   
            this.Accuracy = NewRW.Accuracy;
            this.Attack = NewRW.Attack;
            this.Magic = NewRW.Magic;
            this.Mind = NewRW.Mind;
            this.NickName = NewRW.NickName;
            this.SBName = NewRW.SBName;
            this.SBType = NewRW.SBType;
            this.Slogan = NewRW.Slogan;
            this.Speed = NewRW.Speed;
            return this;
        }

        public DataRelatedRW UpdateRWData(DataTargetProfile NewRW)
        {   
            this.Accuracy = NewRW.Accuracy;
            this.Attack = NewRW.Attack;
            this.Magic = NewRW.Magic;
            this.Mind = NewRW.Mind;
            this.NickName = NewRW.NickName;
            this.SBName = NewRW.SBName;
            this.SBType = NewRW.SBType;
            this.Slogan = NewRW.Slogan;
            this.Speed = NewRW.Speed;
            return this;
        }
    }
}
