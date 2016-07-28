using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DoubleAttackI : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20000001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.WARRIOR; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.7; } }
        public override string Name { get { return "Double Attack I"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
