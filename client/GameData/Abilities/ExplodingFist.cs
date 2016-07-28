using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class ExplodingFist : FFRKInspector.GameData.Ability
    {
        // TODO: AbilityId
        // public override uint AbilityId { get { return; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Monk; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.58; } }
        public override string Name { get { return "Exploding Fist"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
