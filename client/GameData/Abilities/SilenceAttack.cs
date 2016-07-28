using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class SilenceAttack : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30161051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Support; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.4; } }
        public override string Name { get { return "Silence Attack"; } }
        public override int Rarity { get { return 2; } }
    }
}
