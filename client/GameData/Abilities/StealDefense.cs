using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class StealDefense : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30201021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Thief; } }
        public override string Name { get { return "Steal Defense"; } }
        public override int Rarity { get { return 4; } }
    }
}
