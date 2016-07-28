using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class IceJump : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30181031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dragoon; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.1; } }
        public override string Name { get { return "Ice Jump"; } }
        public override int Rarity { get { return 3; } }
        public override bool IsJumpAttack() { return true; }
    }
}
