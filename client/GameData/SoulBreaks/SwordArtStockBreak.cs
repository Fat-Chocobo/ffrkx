using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SwordArtStockBreak : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20570003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.STEINER; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.37; } }
        public override string Name { get { return "Sword Art Stock Break"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
