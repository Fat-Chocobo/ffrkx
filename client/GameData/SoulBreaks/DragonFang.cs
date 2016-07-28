using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DragonFang : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20690002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.AURON; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3.2; } }
        public override string Name { get { return "Dragon Fang"; } }
    }
}
