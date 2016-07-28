using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Pyroclasm : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20700004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.VAAN; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.50; } }
        public override string Name { get { return "Pyroclasm"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
