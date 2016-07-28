using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Revive : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30161191; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Support; } }
        public override string Name { get { return "Revive"; } }
        public override int Rarity { get { return 2; } }
    }
}
