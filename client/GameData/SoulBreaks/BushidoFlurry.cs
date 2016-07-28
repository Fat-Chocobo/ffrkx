using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BushidoFlurry : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20220002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CAYENNE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.8; } }
        public override string Name { get { return "Bushido Flurry"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
