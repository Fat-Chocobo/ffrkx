using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SoothingLight : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20420003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ARC; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 50; } }
        public override string Name { get { return "Soothing Light"; } }
    }
}
