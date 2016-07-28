using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Inferno : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20980004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDGE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1.45; } }
        public override string Name { get { return "Inferno"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
