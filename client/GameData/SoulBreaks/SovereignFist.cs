using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SovereignFist : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20310003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SNOW; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.75; } }
        public override string Name { get { return "Sovereign Fist"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
