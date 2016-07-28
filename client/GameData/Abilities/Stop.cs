using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Stop : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111121; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override string Name { get { return "Stop"; } }
        public override int Rarity { get { return 3; } }
    }
}
