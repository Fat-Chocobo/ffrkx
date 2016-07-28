using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    class DataBuddyAbilityUsage
    {
        [JsonProperty("category_id")]
        public SchemaConstants.AbilityCategory Category;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("rarity")]
        public ushort Rarity;
    }
}
