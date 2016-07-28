using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MinusStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override string Name { get { return "Minus Strike"; } }
        public override int Rarity { get { return 4; } }

        public override double PhysicalDamage(double atk, double def)
        {
            // TODO: IMPLEMENT
            return (double)-1;
        }
    }
}
