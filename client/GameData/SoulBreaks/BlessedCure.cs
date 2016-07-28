using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BlessedCure : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22050001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BEATRIX; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Healing; } }
        public override double Multiplier { get { return 55; } }
        public override string Name { get { return "Blessed Cure"; } }
    }
}
