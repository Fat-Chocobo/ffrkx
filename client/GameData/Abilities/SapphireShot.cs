using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class SapphireShot : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30281001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Sniper; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.65; } }
        public override string Name { get { return "Sapphire Shot"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
