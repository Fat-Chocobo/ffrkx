﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class Meteor : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30111181; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.BlackMagic; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Nothing; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 9; } }
        public override string Name { get { return "Meteor"; } }
        public override int Rarity { get { return 5; } }
    }
}
