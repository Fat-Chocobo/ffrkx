using FFRKInspector.GameData.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RWs
{
    class DataAllRelations
    {
        [JsonProperty("followers")]
        public DataRelationPackage Followers;

        [JsonProperty("followees")]
        public DataRelationPackage Followees;
    }
}
