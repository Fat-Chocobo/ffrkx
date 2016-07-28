using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Jump : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30181001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dragoon; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Jump"; } }
        public override int Rarity { get { return 2; } }
        public override bool IsJumpAttack() { return true; }
    }
}
