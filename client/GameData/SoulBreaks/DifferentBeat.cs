using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DifferentBeat : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20670004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZELL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.99; } }
        public override string Name { get { return "Different Beat"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
