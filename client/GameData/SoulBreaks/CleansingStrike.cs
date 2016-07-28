using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CleansingStrike : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22150003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.AGRIAS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.71; } }
        public override string Name { get { return "Cleansing Strike"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
