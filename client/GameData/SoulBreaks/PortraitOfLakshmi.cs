using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class PortraitOfLakshmi : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22160001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RELM; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 85; } }
        public override string Name { get { return "Portrait of Lakshmi"; } }
    }
}
