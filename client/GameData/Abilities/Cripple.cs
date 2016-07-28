using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Cripple : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30151121; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Combat; } }
        public override string Name { get { return "Cripple"; } }
        public override int Rarity { get { return 3; } }
    }
}
