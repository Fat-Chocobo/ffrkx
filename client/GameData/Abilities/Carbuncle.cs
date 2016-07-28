using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Carbuncle : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131171; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override string Name { get { return "Carbuncle"; } }
        public override int Rarity { get { return 4; } }
    }
}
