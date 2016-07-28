using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DoublecastThunder : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20170002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RED_MAGE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1; } }
        public override string Name { get { return "Doublecast Thunder"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
