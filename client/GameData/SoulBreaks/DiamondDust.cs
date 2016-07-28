using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DiamondDust : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20310004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SNOW; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Diamond Dust"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
