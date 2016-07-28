using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Shout : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22140002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RAMZA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.None; } }
        public override string Name { get { return "Shout"; } }
        public override int NumberOfHits { get { return 0; } }
    }
}
