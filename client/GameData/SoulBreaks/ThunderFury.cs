using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ThunderFury : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20880001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LULU; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 1.1; } }
        public override string Name { get { return "Thunder Fury"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
