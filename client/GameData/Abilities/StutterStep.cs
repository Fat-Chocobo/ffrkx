using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class StutterStep : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30251031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dancer; } }
        public override string Name { get { return "Stutter Step"; } }
        public override int Rarity { get { return 3; } }
    }
}
