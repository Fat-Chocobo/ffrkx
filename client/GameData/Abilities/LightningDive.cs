using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class LightningDive : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30181101; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dragoon; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.13; } }
        public override string Name { get { return "Lightning Dive"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
