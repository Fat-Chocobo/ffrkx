using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Break : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111141; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override string Name { get { return "Break"; } }
        public override int Rarity { get { return 4; } }
    }
}
