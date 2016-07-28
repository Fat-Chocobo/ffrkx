using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ScoopArt : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20860002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZIDANE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.75; } }
        public override string Name { get { return "Scoop Art"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
