﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Roundhouse : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20010003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MONK; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.05; } }
        public override string Name { get { return "Roundhouse"; } }
    }
}
