using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class WildRoseVow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20270003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FRIONIEL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.02; } }
        public override string Name { get { return "Wild Rose Vow"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
