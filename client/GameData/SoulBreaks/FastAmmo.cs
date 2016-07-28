using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FastAmmo : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20410002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.IRVINE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.45; } }
        public override string Name { get { return "Fast Ammo"; } }
        public override int NumberOfHits { get { return 10; } }
    }
}
