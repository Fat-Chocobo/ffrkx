﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class StrahlStrafe : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20440004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.BALFLEAR; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.32; } }
        public override string Name { get { return "Strahl Strafe"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
