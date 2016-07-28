using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BladeBash : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30151011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Combat; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.1; } }
        public override string Name { get { return "Blade Bash"; } }
        public override int Rarity { get { return 1; } }
    }
}
