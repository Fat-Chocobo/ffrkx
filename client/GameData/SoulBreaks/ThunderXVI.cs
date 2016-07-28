using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ThunderXVI : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20560003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MARIA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.6; } }
        public override string Name { get { return "Thunder XVI"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
