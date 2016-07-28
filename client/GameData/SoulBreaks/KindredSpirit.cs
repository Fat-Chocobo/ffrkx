using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class KindredSpirit : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20930002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FARIS; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3.5; } }
        public override string Name { get { return "Kindred Spirit"; } }
    }
}
