using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MementoOfPrayer : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121221; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override string Name { get { return "Memento of Prayer"; } }
        public override int Rarity { get { return 3; } }
    }
}
