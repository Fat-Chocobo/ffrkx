using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Dragon : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20830004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CID; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.29; } }
        public override string Name { get { return "Dragon"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
