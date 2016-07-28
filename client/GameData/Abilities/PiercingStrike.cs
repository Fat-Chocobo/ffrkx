using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class PiercingStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30191081; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Monk; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 20; } }
        public override string Name { get { return "Piercing String"; } }
        public override int Rarity { get { return 4; } }

        public override double PhysicalDamage(double atk, double def)
        {
            return Math.Pow(atk, 0.9);
        }
    }
}
