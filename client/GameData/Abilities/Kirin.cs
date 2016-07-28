﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Kirin : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131101; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override string Name { get { return "Kirin"; } }
        public override int Rarity { get { return 2; } }
    }
}
