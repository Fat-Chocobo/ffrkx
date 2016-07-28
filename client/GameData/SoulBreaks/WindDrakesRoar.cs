﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class WindDrakesRoad : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20940002; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.KRILE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 7.6; } }
        public override string Name { get { return "Wind Drake's Roar"; } }
    }
}
