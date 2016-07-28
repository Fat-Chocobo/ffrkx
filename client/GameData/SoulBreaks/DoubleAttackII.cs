using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DoubleAttackII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20000002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.WARRIOR; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.9; } }
        public override string Name { get { return "Double Attack II"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
