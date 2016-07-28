using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class MistOverload : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20390004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FRAN; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.13; } }
        public override string Name { get { return "Mist Overload"; } }
        public override int NumberOfHits { get { return 7; } }
    }
}
