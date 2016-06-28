﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class BladeBeam : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20110004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.CLOUD; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.05; } }
        public override string Name { get { return "Blade Beam"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
