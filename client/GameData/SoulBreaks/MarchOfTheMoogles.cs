using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class MarchOfTheMoogles : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20880004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LULU; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.24; } }
        public override string Name { get { return "March of the Moogles"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
