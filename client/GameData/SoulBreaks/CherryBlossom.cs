using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CherryBlossom : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22110003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FREYA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.95; } }
        public override string Name { get { return "Cherry Blossom"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
