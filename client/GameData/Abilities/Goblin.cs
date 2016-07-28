using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Goblin : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 600; } }
        public override double Multiplier { get { return 2.7; } }
        public override string Name { get { return "Goblin"; } }
        public override int Rarity { get { return 1; } }
    }
}
