using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Trine : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20470003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RED_XIII; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 7.17; } }
        public override string Name { get { return "Trine"; } }
    }
}
