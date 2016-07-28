using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class GoddesssBell : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20280003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GORDON; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.4; } }
        public override string Name { get { return "Goddess's Bell"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
