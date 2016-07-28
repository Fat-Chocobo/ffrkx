using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DoublecastDecay : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20370004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.VIVI; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.56; } }
        public override string Name { get { return "Doublecast Decay"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
