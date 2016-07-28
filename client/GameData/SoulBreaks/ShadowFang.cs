using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ShadowFang : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20890003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SHADOW; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.96; } }
        public override string Name { get { return "Shadow Fang"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
