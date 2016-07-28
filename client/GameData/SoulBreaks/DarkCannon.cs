using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DarkCannon : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20060004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DARK_CECIL; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 5.2; } }
        public override string Name { get { return "Dark Cannon"; } }
    }
}
