using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class QuickHit : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Celerity; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.4; } }
        public override string Name { get { return "Quick Hit"; } }
        public override int Rarity { get { return 5; } }
    }
}
