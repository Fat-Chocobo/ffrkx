using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ShiningWave : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20330002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.WOL; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 4.8; } }
        public override string Name { get { return "Shining Wave"; } }
    }
}
