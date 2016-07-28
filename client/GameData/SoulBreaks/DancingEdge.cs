using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DancingEdge : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20950002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.THANCRED; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.23; } }
        public override string Name { get { return "Dancing Edge"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
