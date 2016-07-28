using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class SnowballFlurry : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111221; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Snowball Flurry"; } }
        public override int Rarity { get { return 2; } }
    }
}
