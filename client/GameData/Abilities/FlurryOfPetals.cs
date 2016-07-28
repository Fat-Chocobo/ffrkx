using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class FlurryOfPetals : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30231011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Ninja; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.37; } }
        public override string Name { get { return "Flurry of Petals"; } }
        public override int Rarity { get { return 4; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
