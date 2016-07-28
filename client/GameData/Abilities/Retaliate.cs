using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Retaliate : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30221001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Samurai; } }
        public override string Name { get { return "Retaliate"; } }
        public override int Rarity { get { return 2; } }
    }
}
