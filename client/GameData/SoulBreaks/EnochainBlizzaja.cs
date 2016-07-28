using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class EnochainBlizzaja : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 22330001; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.PAPALYMO; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 3.54; } }
        public override string Name { get { return "Enochain Blizzaja"; } }
        public override int NumberOfHits { get { return 5; } }
    }
}
