using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Angelsong : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30241061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Bard; } }
        public override string Name { get { return "Angelsong"; } }
        public override int Rarity { get { return 5; } }
    }
}
