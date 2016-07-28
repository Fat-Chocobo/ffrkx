using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SeikenStockBreak : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22050002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BEATRIX; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.34; } }
        public override string Name { get { return "Seiken Stock Break"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
