using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MementoOfMight : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30191061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Monk; } }
        public override string Name { get { return "Memento of Might"; } }
        public override int Rarity { get { return 3; } }
    }
}
