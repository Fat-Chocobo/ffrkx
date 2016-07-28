using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class AeonsOfWingAndFlame : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22270001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BRASKA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 800; } }
        public override double Multiplier { get { return 2.4; } }
        public override string Name { get { return "Aeons of Wing and Flame"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
