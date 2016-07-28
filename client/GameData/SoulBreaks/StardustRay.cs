using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StardustRay : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20470005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RED_XIII; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.78; } }
        public override string Name { get { return "Stardust Ray"; } }
        public override int NumberOfHits { get { return 10; } }
    }
}
