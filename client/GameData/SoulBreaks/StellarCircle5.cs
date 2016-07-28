using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StellarCircle5 : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20860005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZIDANE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.98; } }
        public override string Name { get { return "Stellar Circle 5"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
