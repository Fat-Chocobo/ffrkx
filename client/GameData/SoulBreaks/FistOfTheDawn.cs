using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FistOfTheDawn : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20650003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GALUF; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 5; } }
        public override string Name { get { return "Fist of the Dawn"; } }
    }
}
