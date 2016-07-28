using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Cry : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30161101; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Support; } }
        public override string Name { get { return "Cry"; } }
        public override int Rarity { get { return 2; } }
    }
}
