using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ChainShot : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22170002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.VINCENT; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.29; } }
        public override string Name { get { return "Chain Shot"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
