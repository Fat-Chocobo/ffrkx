using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ZantetsukenReverse : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20820004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SEIFER; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.00; } }
        public override string Name { get { return "Zantetsuken Reverse"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
