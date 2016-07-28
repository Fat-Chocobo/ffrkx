﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class RazorGale : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20550003; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.MASH; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.33; } }
        public override string Name { get { return "Razor Gale"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
