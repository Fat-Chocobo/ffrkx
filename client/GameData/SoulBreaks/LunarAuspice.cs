using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class LunarAuspice : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20730002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FUSOYA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 525; } }
        public override double Multiplier { get { return 2.35; } }
        public override string Name { get { return "Lunar Auspice"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
