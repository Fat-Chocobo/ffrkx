using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ClockMaster : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22260001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SERAH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 5.9; } }
        public override string Name { get { return "Clock Master"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
