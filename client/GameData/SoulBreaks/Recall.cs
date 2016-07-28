using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Recall : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20640001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TELLAH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.None; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.9; } }
        public override string Name { get { return "Recall"; } }
    }
}
