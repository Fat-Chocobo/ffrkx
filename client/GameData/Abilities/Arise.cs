using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Arise : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121231; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override string Name { get { return "Arise"; } }
        public override int Rarity { get { return 5; } }
    }
}
