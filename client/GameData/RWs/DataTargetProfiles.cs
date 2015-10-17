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
    class DataTargetProfile
    {
        //relation_status = 0 is no relation (from battle selection), 1 is follower, 2 is followee, 3 is mutual
        [JsonProperty("relation_status", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public byte RelationStatus;

        [JsonProperty("user_id")]
        public ulong UserID;

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
    }
}
