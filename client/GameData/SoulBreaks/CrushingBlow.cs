using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CrushingBlow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20600003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LIGHTNING; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.3; } }
        public override string Name { get { return "Crushing Blow"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
