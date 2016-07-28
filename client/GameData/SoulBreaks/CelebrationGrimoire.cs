using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CelebrationGrimoire : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20140007; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 35; } }
        public override string Name { get { return "Celebration Grimoire"; } }
    }
}
