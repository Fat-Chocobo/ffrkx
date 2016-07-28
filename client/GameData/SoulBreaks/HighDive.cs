using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class HighDive : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22030003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FANG; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.4; } }
        public override string Name { get { return "High Dive"; } }
        public override int NumberOfHits { get { return 3; } }
        public override bool IsJumpAttack() { return true; }
    }
}
