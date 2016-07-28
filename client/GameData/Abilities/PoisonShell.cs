using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class PoisonShell : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30261031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Machinist; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.9; } }
        public override string Name { get { return "Poison Shell"; } }
        public override int Rarity { get { return 4; } }
    }
}
