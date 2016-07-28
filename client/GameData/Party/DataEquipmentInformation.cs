using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFRKInspector.GameData;

namespace FFRKInspector.GameData.Party
{
    class DataEquipmentInformation
    {
        [JsonProperty("id")]
        public uint InstanceId;

        [JsonProperty("equipment_id")]
        public uint EquipmentId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("evolution_num")]
        public SchemaConstants.EvolutionLevel EvolutionNumber;

        [JsonProperty("level")]
        public byte Level;

        [JsonProperty("level_max")]
        public byte LevelMax;

        [JsonProperty("rarity")]
        public SchemaConstants.Rarity Rarity;

        [JsonProperty("base_rarity")]
        public SchemaConstants.Rarity BaseRarity;

        [JsonProperty("series_id")]
        public uint SeriesId;

        [JsonProperty("equipment_type")]
        public SchemaConstants.ItemType Type;

        [JsonProperty("hammering_num")]
        public byte Augment;

        [JsonProperty("max_hammering_num")]
        public byte AugmentMax;

        [JsonProperty("hammering_affect_param_key")]
        private string HammeringStat;

        [JsonProperty("atk")]
        public short Atk;
        [JsonProperty("matk")]
        public short Mag;
        [JsonProperty("acc")]
        public short Acc;
        [JsonProperty("def")]
        public short Def;
        [JsonProperty("mdef")]
        public short Res;
        [JsonProperty("eva")]
        public short Eva;
        [JsonProperty("mnd")]
        public short Mnd;
        [JsonProperty("hp")]
        public short HP;
        [JsonProperty("spd")]
        public short Spd;

        [JsonProperty("sp_atk")]
        public short SeriesAtk;
        [JsonProperty("sp_matk")]
        public short SeriesMag;
        [JsonProperty("sp_acc")]
        public short SeriesAcc;
        [JsonProperty("sp_def")]
        public short SeriesDef;
        [JsonProperty("sp_mdef")]
        public short SeriesRes;
        [JsonProperty("sp_eva")]
        public short SeriesEva;
        [JsonProperty("sp_mnd")]
        public short SeriesMnd;
        [JsonProperty("sp_hp")]
        public short SeriesHP;
        [JsonProperty("sp_spd")]
        public short SeriesSpd;

        [JsonProperty("category_id")]
        public SchemaConstants.EquipmentCategory Category;

        public string AugmentStat
        {
            get
            {
                switch (HammeringStat)
                {
                    case "atk":
                    case "acc":
                    case "def":
                    case "eva":
                    case "mnd":
                        return HammeringStat.First().ToString().ToUpper() + HammeringStat.Substring(1);
                    case "matk":
                        return "Mag";
                    case "mdef":
                        return "Res";
                }
                return null;
            }

            set
            {
                HammeringStat = value;
            }
        }

        public short StatInRealm(string stat, uint gameSeries)
        {
            return StatWithSynergy(stat, gameSeries == SeriesId);
        }

        public short StatWithSynergy(string stat, bool hasSynergy)
        {
            string statToUse = hasSynergy ? "Series" + stat : stat;

            System.Reflection.FieldInfo statField = typeof(DataEquipmentInformation).GetField(statToUse);
            short statValue = (short)statField.GetValue(this);

            if (AugmentStat != null && AugmentStat == stat)
            {
                statValue = (short)Math.Ceiling((hasSynergy ? Augment * 1.5 : (double)Augment) + statValue);
            }
            return statValue;
        }

        public double ElementalMultiplier(SchemaConstants.ElementID element)
        {
            SchemaConstants.ElementID storedElement;

            if (EquipmentElementalInformation.ElementalEquipment.TryGetValue(EquipmentId, out storedElement) && storedElement == element)
            {
                return 1.2;
            }
            return 1.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
