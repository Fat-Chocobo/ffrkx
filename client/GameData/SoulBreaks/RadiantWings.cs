using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RadiantWings : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20070004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.PALADIN_CECIL; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.6; } }
        public override string Name { get { return "Radiant Wings"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
