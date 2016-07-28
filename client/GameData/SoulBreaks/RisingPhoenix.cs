using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RisingPhoenix : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20550002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MASH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 3.1; } }
        public override string Name { get { return "Rising Phoenix"; } }
    }
}
