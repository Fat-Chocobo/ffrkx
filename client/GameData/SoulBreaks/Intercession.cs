using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Intercession : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22060003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.PENELO; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.00; } }
        public override string Name { get { return "Intercession"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
