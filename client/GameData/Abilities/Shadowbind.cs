using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Shadowbind : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Celerity; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.1; } }
        public override string Name { get { return "Shadowbind"; } }
        public override int Rarity { get { return 4; } }
    }
}
