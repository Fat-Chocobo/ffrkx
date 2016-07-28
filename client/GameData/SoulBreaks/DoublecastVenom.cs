using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DoublecastVenom : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20370002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.VIVI; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Poison; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 5.2; } }
        public override string Name { get { return "Doublecast Venom"; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
