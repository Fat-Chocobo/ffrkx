using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ScarletElan : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20870003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.AMARANT; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.39; } }
        public override string Name { get { return "Scarlet Elan"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
