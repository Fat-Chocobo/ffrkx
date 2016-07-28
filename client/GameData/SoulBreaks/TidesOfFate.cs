using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TidesOfFate : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20440002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BALFLEAR; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3.1; } }
        public override string Name { get { return "Tides of Fate"; } }
    }
}
