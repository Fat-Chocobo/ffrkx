using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class PrismaticFlash : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20780003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SETZER; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.40; } }
        public override string Name { get { return "Prismatic Flash"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
