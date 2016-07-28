using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Barrage : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30151111; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Combat; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.7; } }
        public override string Name { get { return "Barrage"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
