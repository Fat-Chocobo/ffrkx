using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class UltimaArrow : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22260002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SERAH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2.84; } }
        public override string Name { get { return "Ultima Arrow"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
