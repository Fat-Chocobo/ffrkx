using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MugTime : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30201041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Thief; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.5; } }
        public override string Name { get { return "Mug Time"; } }
        public override int Rarity { get { return 5; } }
    }
}
