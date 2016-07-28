using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class MagitekMissile : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20100004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.TINA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.63; } }
        public override string Name { get { return "Magitek Missile"; } }
        public override int NumberOfHits { get { return 10; } }
    }
}
