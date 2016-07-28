using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class AquaBreath : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20720002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.STRAGUS; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 7.25; } }
        public override string Name { get { return "Aqua Breath"; } }
    }
}
