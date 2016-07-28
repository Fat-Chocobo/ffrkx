using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Boost : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30161021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Support; } }
        public override string Name { get { return "Boost"; } }
        public override int Rarity { get { return 1; } }
    }
}
