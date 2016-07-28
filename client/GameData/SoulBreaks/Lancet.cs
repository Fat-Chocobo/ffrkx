using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Lancet : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20080002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CAIN; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 4; } }
        public override string Name { get { return "Lancet"; } }
    }
}
