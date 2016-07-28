using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class HighJump : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20590001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DRAGOON; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.1; } }
        public override string Name { get { return "High Jump"; } }
        public override bool IsJumpAttack() { return true; }
    }
}
