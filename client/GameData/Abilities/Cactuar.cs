using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Cactuar : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131221; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override string Name { get { return "Cactuar"; } }
        public override int NumberOfHits { get { return 3; } }
        public override int Rarity { get { return 4; } }
    }
}
