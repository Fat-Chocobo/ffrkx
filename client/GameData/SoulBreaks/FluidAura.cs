using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class FluidAura : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20960001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YSHTOLA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.9; } }
        public override string Name { get { return "Fluid Aura"; } }
    }
}
