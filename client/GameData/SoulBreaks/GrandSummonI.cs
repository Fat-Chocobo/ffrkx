using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class GrandSummonI : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20520001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.YUNA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 100; } }
        public override double Multiplier { get { return 1.1; } }
        public override string Name { get { return "Grand Summon I"; } }
    }
}
