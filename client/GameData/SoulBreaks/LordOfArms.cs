using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LordOfArms : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20270004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FRIONIEL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.56; } }
        public override string Name { get { return "Lord of Arms"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
