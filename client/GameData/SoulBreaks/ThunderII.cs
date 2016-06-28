﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class ThunderII : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22130001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.LEILA; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Lightning; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 2; } }
        public override string Name { get { return "Thunder II"; } }
    }
}
