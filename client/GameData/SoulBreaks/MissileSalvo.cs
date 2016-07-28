using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class MissileSalvo : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22100003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LAGUNA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 0.88; } }
        public override string Name { get { return "Missile Salvo"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
