using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SylphsProvidence : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22340001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YANG; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.40; } }
        public override string Name { get { return "Sylph's Providence"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
