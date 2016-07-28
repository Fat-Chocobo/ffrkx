using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class DrawFire : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211002; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override string Name { get { return "Draw Fire"; } }
        public override int Rarity { get { return 3; } }
    }
}
