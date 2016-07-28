using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Drill : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20530003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDGAR; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.67; } }
        public override string Name { get { return "Drill"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
