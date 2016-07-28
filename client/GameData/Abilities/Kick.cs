using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Kick : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30191051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Monk; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.3; } }
        public override string Name { get { return "Kick"; } }
        public override int Rarity { get { return 3; } }
    }
}
