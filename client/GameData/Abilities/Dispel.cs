using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Dispel : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121171; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override string Name { get { return "Dispel"; } }
        public override int Rarity { get { return 3; } }
    }
}
