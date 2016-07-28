using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ShiftBreak : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20860004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZIDANE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Shift Break"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
