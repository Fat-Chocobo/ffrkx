using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class DarkZone : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30271021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Darkness; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.5; } }
        public override string Name { get { return "Dark Zone"; } }
        public override int Rarity { get { return 4; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
