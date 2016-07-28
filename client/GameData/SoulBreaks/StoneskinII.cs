using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StoneskinII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20960002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YSHTOLA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.None; } }
        public override string Name { get { return "Stoneskin II"; } }
        public override int NumberOfHits { get { return 0; } }
    }
}
