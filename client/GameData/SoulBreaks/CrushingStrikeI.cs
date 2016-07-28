using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CrushingStrikeI : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20750001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.VIKING; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.7; } }
        public override string Name { get { return "Crushing Strike I"; } }
    }
}
