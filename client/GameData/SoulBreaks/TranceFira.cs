using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TranceFira : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20100002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TINA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 7.17; } }
        public override string Name { get { return "Trance Fira"; } }
    }
}
