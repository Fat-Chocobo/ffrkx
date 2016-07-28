using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Bomb : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 600; } }
        public override double Multiplier { get { return 2.7; } }
        public override string Name { get { return "Bomb"; } }
        public override int Rarity { get { return 1; } }
    }
}
