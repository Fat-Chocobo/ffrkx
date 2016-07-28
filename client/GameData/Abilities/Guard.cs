using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Guard : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override string Name { get { return "Guard"; } }
        public override int Rarity { get { return 2; } }
    }
}
