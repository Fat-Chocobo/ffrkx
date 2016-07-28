using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Charge : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30151031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Combat; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.75; } }
        public override string Name { get { return "Charge"; } }
        public override int Rarity { get { return 2; } }
    }
}
