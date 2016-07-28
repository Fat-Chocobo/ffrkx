using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Ultima : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111241; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 5.25; } }
        public override string Name { get { return "Ultima"; } }
        public override int Rarity { get { return 6; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
