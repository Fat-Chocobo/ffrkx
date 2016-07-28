using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class NibelheimNightmare : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20250005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SEPHIROTH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1; } }
        public override string Name { get { return "Nibelheim Nightmare"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
