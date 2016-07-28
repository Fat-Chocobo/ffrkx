using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class IaiStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30221011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Samurai; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.6; } }
        public override string Name { get { return "Iai Strike"; } }
        public override int Rarity { get { return 3; } }
    }
}
