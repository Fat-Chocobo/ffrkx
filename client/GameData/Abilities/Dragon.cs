using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Dragon : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 600; } }
        public override double Multiplier { get { return 3.6; } }
        public override string Name { get { return "Dragon"; } }
        public override int Rarity { get { return 2; } }
    }
}
