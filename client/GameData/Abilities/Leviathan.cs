using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Leviathan : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131081; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 1100; } }
        public override double Multiplier { get { return 4.4; } }
        public override string Name { get { return "Leviathan"; } }
        public override int Rarity { get { return 4; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
