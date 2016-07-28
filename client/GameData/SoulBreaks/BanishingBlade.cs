using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BanishingBlade : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20690004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.AURON; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.56; } }
        public override string Name { get { return "Banishing Blade"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
