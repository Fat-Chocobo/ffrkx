using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Wound : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22260003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SERAH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 0.95; } }
        public override string Name { get { return "Wound"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
