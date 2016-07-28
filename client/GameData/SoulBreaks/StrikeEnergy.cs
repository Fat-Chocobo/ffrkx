using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StrikeEnergy : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22240003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.KUJA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.00; } }
        public override string Name { get { return "Strike Energy"; } }
    }
}
