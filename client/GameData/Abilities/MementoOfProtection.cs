using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MementoOfProtection : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override string Name { get { return "Memento of Protection"; } }
        public override int Rarity { get { return 3; } }
    }
}
