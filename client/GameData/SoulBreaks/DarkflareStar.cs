using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DarkflareStar : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22240001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.KUJA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 500; } }
        public override double Multiplier { get { return 2.2; } }
        public override string Name { get { return "Darkflare Star"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
