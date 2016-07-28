using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ValiantStrike : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20240005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LOCK; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1; } }
        public override string Name { get { return "Valiant Strike"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
