using FFRKInspector.GameData.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RWs
{
    class DataRelationPackage
    {
        [JsonProperty("target_profiles")]
        public List<DataTargetProfile> Profiles;

        [JsonProperty("user_relations")]
        public List<DataRelatedRW> Users;
    }
}
