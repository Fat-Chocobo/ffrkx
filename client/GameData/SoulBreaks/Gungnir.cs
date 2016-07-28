using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Gungnir : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20080003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CAIN; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 5; } }
        public override string Name { get { return "Gungnir"; } }
        public override bool IsJumpAttack() { return true; }
    }
}
