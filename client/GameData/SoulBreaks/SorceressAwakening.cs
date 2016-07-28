using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SorceressAwakening : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20300006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RINOA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Earth; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1.8; } }
        public override string Name { get { return "Sorceress' Awakening"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
