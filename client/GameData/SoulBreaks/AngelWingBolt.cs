using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class AngelWingBolt : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20300002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RINOA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3; } }
        public override string Name { get { return "Angel Wing Bolt"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
