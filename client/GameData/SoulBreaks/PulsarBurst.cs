using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class PulsarBurst : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22030002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FANG; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.02; } }
        public override string Name { get { return "Pulsar Burst"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
