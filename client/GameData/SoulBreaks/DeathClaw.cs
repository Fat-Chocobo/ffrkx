using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DeathClaw : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20810002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GILGAMESH; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.7; } }
        public override string Name { get { return "Death Claw"; } }
        public override int NumberOfHits { get { return 3; } }
        public override bool IsJumpAttack() { return true; }
    }
}
