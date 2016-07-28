using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class WindSlash : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30171031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Celerity; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override double Multiplier { get { return 1.4; } }
        public override string Name { get { return "Wind Slash"; } }
        public override int Rarity { get { return 2; } }
    }
}
