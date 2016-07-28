using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Reunion : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20250006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SEPHIROTH; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.54; } }
        public override string Name { get { return "Reunion"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
