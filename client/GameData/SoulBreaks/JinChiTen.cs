using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class JinChiTen : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20950004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.THANCRED; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.49; } }
        public override string Name { get { return "Jin Chi Ten"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
