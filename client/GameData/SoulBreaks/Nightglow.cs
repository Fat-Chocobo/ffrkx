using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Nightglow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20630003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GOLBEZ; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.75; } }
        public override string Name { get { return "Nightglow"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
