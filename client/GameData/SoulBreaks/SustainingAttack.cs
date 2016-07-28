using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SustainingAttack : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22230003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESCH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 0.67; } }
        public override string Name { get { return "Sustaining Attack"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
