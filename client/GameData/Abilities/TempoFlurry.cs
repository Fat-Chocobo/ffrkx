using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class TempoFlurry : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171081; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Celerity; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.9; } }
        public override string Name { get { return "Tempo Flurry"; } }
        public override int Rarity { get { return 3; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
