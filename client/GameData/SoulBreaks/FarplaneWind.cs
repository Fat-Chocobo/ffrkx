using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FarplaneWind : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20520006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YUNA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.93; } }
        public override string Name { get { return "Farplane Wind"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
