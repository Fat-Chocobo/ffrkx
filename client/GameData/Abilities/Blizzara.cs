using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Blizzara : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111012; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.9; } }
        public override string Name { get { return "Blizzara"; } }
        public override int Rarity { get { return 2; } }
    }
}
