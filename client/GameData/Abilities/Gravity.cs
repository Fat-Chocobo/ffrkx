using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Gravity : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111111; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override string Name { get { return "Gravity"; } }
        public override int Rarity { get { return 3; } }
    }
}
