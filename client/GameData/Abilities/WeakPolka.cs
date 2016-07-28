using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class WeakPolka : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30251041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dancer; } }
        public override string Name { get { return "Weak Polka"; } }
        public override int Rarity { get { return 3; } }
    }
}
