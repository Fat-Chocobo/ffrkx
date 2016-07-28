using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Landscaper : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22040001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YUFFIE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Earth; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.2; } }
        public override string Name { get { return "Landscaper"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
