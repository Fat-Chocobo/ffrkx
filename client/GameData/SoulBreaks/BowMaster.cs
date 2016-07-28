using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BowMaster : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20560001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MARIA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.1; } }
        public override string Name { get { return "Bow Master"; } }
    }
}
