using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FatedCircle : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20350003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SQUALL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.85; } }
        public override string Name { get { return "Fated Circle"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
