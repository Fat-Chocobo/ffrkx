using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LastResort : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20770004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.HOPE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.24; } }
        public override string Name { get { return "Last Resort"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
