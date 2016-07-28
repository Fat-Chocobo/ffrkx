using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DreadOfDeath : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22240002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.KUJA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.35; } }
        public override string Name { get { return "Dread of Death"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
