using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class EblanDualWield : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20980003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.EDGE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.66; } }
        public override string Name { get { return "Eblan Dual Wield"; } }
        public override int NumberOfHits { get { return 8; } }
    }
}
