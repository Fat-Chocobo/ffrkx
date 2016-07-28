using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SpinningEdgeVI : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20210003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CELES; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.7; } }
        public override string Name { get { return "Spinning Edge (VI)"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
