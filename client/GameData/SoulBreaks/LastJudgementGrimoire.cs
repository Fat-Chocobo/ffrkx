using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LastJudgementGrimoire : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20140005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Earth; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Last Judgement Grimoire"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
