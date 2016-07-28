using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Electrocute : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20500001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.QUISTIS; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1.4; } }
        public override string Name { get { return "Electrocute"; } }
    }
}
