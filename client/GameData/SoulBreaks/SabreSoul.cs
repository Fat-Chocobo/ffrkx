using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SabreSoul : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20720003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.STRAGUS; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.74; } }
        public override string Name { get { return "Sabre Soul"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
