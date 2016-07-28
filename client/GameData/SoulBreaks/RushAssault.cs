using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RushAssault : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20660002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZACK; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.65; } }
        public override string Name { get { return "Rush Assault"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
