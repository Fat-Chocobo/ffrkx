using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MultiBreak : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30251071; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dancer; } }
        public override string Name { get { return "Multi Break"; } }
        public override int Rarity { get { return 5; } }
    }
}
