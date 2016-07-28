using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Darkbolt : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20020001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BLACK_MAGE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1.6; } }
        public override string Name { get { return "Darkbolt"; } }
    }
}
