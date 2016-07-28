using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BloodfestVII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22040004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YUFFIE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.66; } }
        public override string Name { get { return "Bloodfest (VII)"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
