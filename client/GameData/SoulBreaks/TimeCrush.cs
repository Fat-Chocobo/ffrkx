using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TimeCrush : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22200004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDEA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.56; } }
        public override string Name { get { return "Time Crush"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
