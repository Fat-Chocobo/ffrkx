using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class HealingStep : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22060001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.PENELO; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 45; } }
        public override string Name { get { return "Healing Step"; } }
    }
}
