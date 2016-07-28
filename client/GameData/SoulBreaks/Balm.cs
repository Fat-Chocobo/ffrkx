using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Balm : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 21000047; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GILBERT; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 55; } }
        public override string Name { get { return "Balm"; } }
    }
}
