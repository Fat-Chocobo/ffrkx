using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RequiemOfTheGoddess : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20600005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LIGHTNING; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.15; } }
        public override string Name { get { return "Requiem of the Goddess"; } }
        public override int NumberOfHits { get { return 7; } }
    }
}
