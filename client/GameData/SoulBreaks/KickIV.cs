using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class KickIV : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22340002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YANG; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.1; } }
        public override string Name { get { return "Kick (IV)"; } }
    }
}
