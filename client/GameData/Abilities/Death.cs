using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Death : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override string Name { get { return "Death"; } }
        public override int Rarity { get { return 4; } }
    }
}
