using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ToySoldier : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22250001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CAITSITH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.16; } }
        public override string Name { get { return "Toy Soldier"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
