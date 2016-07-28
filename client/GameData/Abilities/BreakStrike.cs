using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BreakStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30141071; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Spellblade; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.1; } }
        public override string Name { get { return "Break Strike"; } }
        public override int Rarity { get { return 4; } }
    }
}
