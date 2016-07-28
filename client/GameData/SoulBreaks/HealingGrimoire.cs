using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class HealingGrimoire : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20140002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 104; } }
        public override string Name { get { return "Healing Grimoire"; } }
    }
}
