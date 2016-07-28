using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Holy : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121131; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 12; } }
        public override string Name { get { return "Holy"; } }
        public override int Rarity { get { return 5; } }
    }
}
