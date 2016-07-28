using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class SkyGrinder : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30181051; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dragoon; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.15; } }
        public override string Name { get { return "Sky Grinder"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 2; } }
        public override bool IsJumpAttack() { return true; }
    }
}
