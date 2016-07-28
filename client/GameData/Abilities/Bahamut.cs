﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Bahamut : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30131211; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Summoning; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 2500; } }
        public override double Multiplier { get { return 7.5; } }
        public override string Name { get { return "Bahamut"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
