using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BrutalSanction : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20770002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.HOPE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.5; } }
        public override string Name { get { return "Brutal Sanction"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
