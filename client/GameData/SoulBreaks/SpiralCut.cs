using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SpiralCut : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20130021; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TIDUS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 4.8; } }
        public override string Name { get { return "Sprial Cut"; } }
    }
}
