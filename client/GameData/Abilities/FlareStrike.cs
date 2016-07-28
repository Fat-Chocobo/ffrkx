using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class FlareStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30141041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Spellblade; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3; } }
        public override string Name { get { return "Flare Strike"; } }
        public override int Rarity { get { return 5; } }
    }
}
