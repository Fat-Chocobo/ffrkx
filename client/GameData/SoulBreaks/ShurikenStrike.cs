﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ShurikenStrike : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20890002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.SHADOW; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Shuriken Strike"; } }
    }
}
