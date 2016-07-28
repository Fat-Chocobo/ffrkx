using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class StumbleStep : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30251032; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dancer; } }
        public override string Name { get { return "Stumble Step"; } }
        public override int Rarity { get { return 4; } }
    }
}
