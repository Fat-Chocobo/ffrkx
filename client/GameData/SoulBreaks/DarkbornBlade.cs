using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DarkbornBlade : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20580003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LEON; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.0; } }
        public override string Name { get { return "Darkborn Blade"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
