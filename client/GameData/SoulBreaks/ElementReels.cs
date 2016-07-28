using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ElementReels : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20150001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.WAKKA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.25; } }
        public override string Name { get { return "Element Reels"; } }
    }
}
