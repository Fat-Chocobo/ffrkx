﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class DragonBreath : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22110001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.FREYA; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.03; } }
        public override string Name { get { return "Dragon Breath"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
