using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DiveBomb : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20780001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SETZER; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.9; } }
        public override string Name { get { return "Dive Bomb"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
