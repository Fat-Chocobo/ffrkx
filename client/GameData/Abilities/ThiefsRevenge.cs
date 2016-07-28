using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class ThiefsRevenge : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30201051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Thief; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.7; } }
        public override string Name { get { return "Thief's Revenge"; } }
        public override int Rarity { get { return 5; } }
    }
}
