using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SwiftcastFira : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22330002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.PAPALYMO; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.13; } }
        public override string Name { get { return "Swiftcast Fira"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
