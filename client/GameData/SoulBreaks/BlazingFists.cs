using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BlazingFists : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20430004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.REFIA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.98; } }
        public override string Name { get { return "Blazing Fists"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
