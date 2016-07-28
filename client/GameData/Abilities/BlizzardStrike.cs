﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BlizzardStrike : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30141011; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Spellblade; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Ice; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Blizzard Strike"; } }
        public override int Rarity { get { return 2; } }
    }
}
