using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SoulEater : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20060005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DARK_CECIL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.5; } }
        public override string Name { get { return "Soul Eater"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
