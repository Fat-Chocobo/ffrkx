using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ElementOfTreachery : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20440003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BALFLEAR; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.51; } }
        public override string Name { get { return "Element of Treachery"; } }
        public override int NumberOfHits { get { return 10; } }
    }
}
