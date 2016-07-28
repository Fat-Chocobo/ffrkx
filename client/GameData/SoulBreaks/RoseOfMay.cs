﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RoseOfMay : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22050003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BEATRIX; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.29; } }
        public override string Name { get { return "Rose of May"; } }
        public override int NumberOfHits { get { return 4; } }
    }
}
