using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Blind : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111201; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override string Name { get { return "Blind"; } }
        public override int Rarity { get { return 1; } }
    }
}
