using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class ArmorStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30211061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Knight; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.8; } }
        public override string Name { get { return "Armor Strike"; } }
        public override int Rarity { get { return 4; } }

        public override double PhysicalDamage(double atk, double def)
        {
            // TODO: IMPLEMENT
            return (double)-1;
        }
    }
}
