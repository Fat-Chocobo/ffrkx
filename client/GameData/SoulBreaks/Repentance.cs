using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Repentance : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20810005; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.GILGAMESH; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.71; } }
        public override string Name { get { return "Repentance"; } }
        public override int NumberOfHits { get { return 3; } }
        public override bool IsJumpAttack() { return true; }
    }
}
