using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RumbleRush : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20860003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZIDANE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.28; } }
        public override string Name { get { return "Rumble Rush"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
