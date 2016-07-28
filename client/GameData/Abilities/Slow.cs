using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Slow : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30121071; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.WhiteMagic; } }
        public override string Name { get { return "Slow"; } }
        public override int Rarity { get { return 1; } }
    }
}
