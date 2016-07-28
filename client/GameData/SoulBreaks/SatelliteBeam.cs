using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SatelliteBeam : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20760004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BARRET; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.38; } }
        public override string Name { get { return "Satellite Beam"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
