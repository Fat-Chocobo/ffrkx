﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class TurkBombshell : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20920004; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.RENO; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 4.8; } }
        public override string Name { get { return "Turk Bombshell"; } }
        public override int NumberOfHits { get { return 3; } }
    }
}
