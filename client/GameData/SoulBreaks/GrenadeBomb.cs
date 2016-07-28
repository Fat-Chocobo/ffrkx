using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class GrenadeBomb : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20760002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BARRET; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3.2; } }
        public override string Name { get { return "Grenade Bomb"; } }
    }
}
