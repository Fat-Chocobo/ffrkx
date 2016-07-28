using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SliceAndDice : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20130003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TIDUS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.85; } }
        public override string Name { get { return "Slice & Dice"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
