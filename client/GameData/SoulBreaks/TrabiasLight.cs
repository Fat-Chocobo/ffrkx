using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TrabiasLight : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20510002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SELPHIE; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 56; } }
        public override string Name { get { return "Trabia's Light"; } }
    }
}
