using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class AstralPunch : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22200003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDEA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1; } }
        public override string Name { get { return "Astral Punch"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
