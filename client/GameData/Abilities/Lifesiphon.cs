using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Lifesiphon : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171111; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Combat; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.8; } }
        public override string Name { get { return "Lifesiphon"; } }
        public override int Rarity { get { return 4; } }
    }
}
