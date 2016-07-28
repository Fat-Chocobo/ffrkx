using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class GaiasVengeance : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20800003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.INGUS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.58; } }
        public override string Name { get { return "Gaia's Vengeance"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
