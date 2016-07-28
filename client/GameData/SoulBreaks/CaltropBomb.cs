using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class CaltropBomb : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20610003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SAZH; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.2; } }
        public override string Name { get { return "Caltrop Bomb"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
