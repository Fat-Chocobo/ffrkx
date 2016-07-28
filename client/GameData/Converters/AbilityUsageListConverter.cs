using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FFRKInspector.GameData.Converters
{
    class AbilityUsageListConverter : CustomCreationConverter<List<DataBuddyAbilityUsage>>
    {
        public override List<DataBuddyAbilityUsage> Create(Type objectType)
        {
            return new List<DataBuddyAbilityUsage>();
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            JObject obj = JObject.Load(reader);

            List<DataBuddyAbilityUsage> target = Create(objectType);

            IList<JToken> results = obj.Children().ToList();

            foreach (JToken result in results)
            {
                DataBuddyAbilityUsage usage = JsonConvert.DeserializeObject<DataBuddyAbilityUsage>(result.First.ToString());
                target.Add(usage);
            }

            return target;
        }
    }
}
