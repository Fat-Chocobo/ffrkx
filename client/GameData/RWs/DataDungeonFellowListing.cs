using FFRKInspector.GameData.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RWs
{
    class DataDungeonFellowListing
    {
        [JsonProperty("detailed_fellows")]
        public List<DataTargetProfile> Profiles;

        [JsonProperty("fellow_listing_user_ids")]
        public List<Object> ObjectUserID;
    }
}
