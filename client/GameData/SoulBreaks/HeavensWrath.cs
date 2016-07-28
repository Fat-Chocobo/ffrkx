﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class HeavensWrath : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20710003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.ASHE; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Holy; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.66; } }
        public override string Name { get { return "Heaven's Wrath"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
