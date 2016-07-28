using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class AquaBurst : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30281011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Sniper; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Aqua Burst"; } }
        public override int Rarity { get { return 4; } }
    }
}
