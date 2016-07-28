using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class NorthswainsGlow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20710001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ASHE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 7; } }
        public override string Name { get { return "Northswain's Glow"; } }
    }
}
