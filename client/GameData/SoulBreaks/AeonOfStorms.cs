using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class AeonOfStorms : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22270002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BRASKA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 55; } }
        public override double Multiplier { get { return 0.55; } }
        public override string Name { get { return "Aeon of Storms"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
