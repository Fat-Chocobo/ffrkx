using FFRKInspector.GameData.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    class DataBuddyInformation
    {
        [JsonProperty("row")]
        public SchemaConstants.PartyFormation Formation;

        [JsonProperty("id")]
        public uint Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("ability_1_id")]
        public uint Ability1;

        [JsonProperty("ability_2_id")]
        public uint Ability2;

        [JsonProperty("level")]
        public byte Level;

        [JsonProperty("level_max")]
        public byte LevelMax;

        [JsonProperty("default_soul_strike_id")]
        public uint SoulStrike;

        [JsonProperty("job_name")]
        public string Job;

        [JsonProperty("weapon_id")]
        public uint WeaponId;

        [JsonProperty("armor_id")]
        public uint ArmorId;

        [JsonProperty("accessory_id")]
        public uint AccessoryId;

        [JsonProperty("buddy_id")]
        public uint BuddyId;

        [JsonProperty("series_id")]
        public uint SeriesId;

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

        [JsonProperty("equipment_category")]
        [JsonConverter(typeof(EquipUsageListConverter))]
        public List<DataBuddyEquipUsage> EquipUsage;

        [JsonProperty("ability_category")]
        [JsonConverter(typeof(AbilityUsageListConverter))]
        public List<DataBuddyAbilityUsage> AbilityUsage;

        [JsonProperty("soul_strike_exp_map")]
        public Dictionary<uint, uint> SoulBreakExpMap;

        public IEnumerable<SchemaConstants.EquipmentCategory> UsableEquipCategories
        {
            get {  return EquipUsage.Select(x => x.Category); }
        }

        public bool CanUseAbility(FFRKInspector.GameData.Ability ability)
        {
            return AbilityUsage.Count(ab => ab.Category == ability.Category && ab.Rarity >= ability.Rarity) > 0;
        }

        public bool EligibleForNightmareShift(FFRKInspector.GameData.SchemaConstants.AbilityCategory nightmareCategory)
        {
            return AbilityUsage.Count(ability => ability.Category == nightmareCategory && ability.Rarity >= 5) > 0;
        }

        public IEnumerable<SoulBreak> UsableSoulBreaks
        {
            get { return SoulBreak.AllSoulBreaks().Where(soulBreak => SoulBreakExpMap.Keys.Any(sb => sb == soulBreak.SoulBreakId)
                || soulBreak.SoulBreakId == SoulStrike); }
        }

        public short StatInRealm(string stat, uint gameSeries)
        {
            return StatWithSynergy(stat, gameSeries == SeriesId);
        }

        public short StatWithSynergy(string stat, bool hasSynergy)
        {
            string statToUse = hasSynergy ? "Series" + stat : stat;

            System.Reflection.FieldInfo statField = typeof(DataBuddyInformation).GetField(statToUse);
            return (short)statField.GetValue(this);
        }

        public override string ToString()
        {
            if (Name == "Cecil")
            {
                if (Job == "Dark Knight")
                {
                    return "Cecil DK";
                }
                return "Cecil PLD";
            }
            return Name;
        }
    }
}
