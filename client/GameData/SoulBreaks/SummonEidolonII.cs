using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class SummonEidolonII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20090002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RYDIA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 1050; } }
        public override double Multiplier { get { return 7.17; } }
        public override string Name { get { return "Summon Eidolon II"; } }
    }
}
