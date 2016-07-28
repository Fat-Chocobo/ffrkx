using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DarkShotVIII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20410004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.IRVINE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.32; } }
        public override string Name { get { return "Dark Shot (VIII)"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
