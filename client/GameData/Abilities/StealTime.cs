using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class StealTime : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30201011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Thief; } }
        public override string Name { get { return "Steal Time"; } }
        public override int Rarity { get { return 3; } }
    }
}
