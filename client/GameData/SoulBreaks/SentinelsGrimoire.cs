using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SentinelsGrimoire : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20140004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.None; } }
        public override string Name { get { return "Sentinel's Grimoire"; } }
        public override int NumberOfHits { get { return 0; } }
    }
}
