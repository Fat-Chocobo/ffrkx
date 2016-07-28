using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TruebladeOfLegend : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20400004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BUTS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.58; } }
        public override string Name { get { return "Trueblade of Legend"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
