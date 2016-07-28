using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Leviathan : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20360003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GARNET; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.5; } }
        public override string Name { get { return "Leviathan"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
