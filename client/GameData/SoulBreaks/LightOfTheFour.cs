using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LightOfTheFour : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20400006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BUTS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.33; } }
        public override string Name { get { return "Light of the Four"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
