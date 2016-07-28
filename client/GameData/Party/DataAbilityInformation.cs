using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFRKInspector.GameData;

namespace FFRKInspector.GameData.Party
{
    class DataAbilityInformation
    {
        [JsonProperty("id")]
        public uint InstanceId;

        [JsonProperty("ability_id")]
        public uint AbilityId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("grade")]
        public byte Level;

        [JsonProperty("max_grade")]
        public byte LevelMax;

        [JsonProperty("rarity")]
        public SchemaConstants.Rarity Rarity;

        [JsonProperty("num")]
        public byte NumberOfUses;

        [JsonProperty("category_id")]
        public SchemaConstants.AbilityCategory Category;

        public GameData.Ability Ability
        {
            get
            {
                return GameData.Ability.AllAbilities().FirstOrDefault(ability => ability.AbilityId == AbilityId);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
