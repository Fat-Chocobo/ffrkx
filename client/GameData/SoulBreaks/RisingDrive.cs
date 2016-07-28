using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RisingDrive : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20080004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CAIN; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.95; } }
        public override string Name { get { return "Rising Drive"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
