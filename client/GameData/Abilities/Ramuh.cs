using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Ramuh : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 750; } }
        public override double Multiplier { get { return 2.75; } }
        public override string Name { get { return "Ramuh"; } }
        public override int Rarity { get { return 3; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
