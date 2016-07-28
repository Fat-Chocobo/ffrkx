using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BladeFlurry : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20350001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SQUALL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.6; } }
        public override string Name { get { return "Blade Flurry"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
