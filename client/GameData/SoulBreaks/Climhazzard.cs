using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Climhazzard : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20110006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CLOUD; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Wind; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.73; } }
        public override string Name { get { return "Climhazzard"; } }
        public override int NumberOfHits { get { return 7; } }
    }
}
