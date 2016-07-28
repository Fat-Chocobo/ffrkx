using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SteadyShotII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20040002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RANGER; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.8; } }
        public override string Name { get { return "Steady Shot II"; } }
    }
}
