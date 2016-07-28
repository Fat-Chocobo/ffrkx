using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StormlanceGrimoire : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20140000; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Stormlance Grimoire"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
