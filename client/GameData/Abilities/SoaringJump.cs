﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class SoaringJump : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30181021; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dragoon; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.5; } }
        public override string Name { get { return "Soaring Jump"; } }
        public override int Rarity { get { return 4; } }
    }
}
