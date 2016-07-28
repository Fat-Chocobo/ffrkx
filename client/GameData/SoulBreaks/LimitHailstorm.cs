using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LimitHailstorm : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22100004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LAGUNA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.85; } }
        public override string Name { get { return "Limit: Hailstorm"; } }
        public override int NumberOfHits { get { return 7; } }
    }
}
