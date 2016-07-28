using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Apocalypse : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20660004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ZACK; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Apocalypse"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
