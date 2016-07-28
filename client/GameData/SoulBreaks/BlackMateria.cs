using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BlackMateria : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20470005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SEPHIROTH; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.95; } }
        public override string Name { get { return "Black Materia"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
