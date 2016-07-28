using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Quickness : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Celerity; } }
        public override string Name { get { return "Quickness"; } }
        public override int Rarity { get { return 3; } }
    }
}
