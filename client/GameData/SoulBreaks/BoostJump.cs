using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BoostJump : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20830001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CID; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Boost Jump"; } }
        public override bool IsJumpAttack() { return true; }
    }
}
