using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BracingBash : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.6; } }
        public override string Name { get { return "Bracing Bash"; } }
        public override int Rarity { get { return 3; } }
    }
}
