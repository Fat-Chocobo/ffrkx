﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class FireBlossom : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30221061; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Samurai; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Fire; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.6; } }
        public override string Name { get { return "Fire Blossom"; } }
        public override int Rarity { get { return 4; } }
    }
}
