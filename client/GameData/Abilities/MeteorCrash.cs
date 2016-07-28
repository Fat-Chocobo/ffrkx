using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MeteorCrash : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30191101; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Monk; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Earth; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.5; } }
        public override string Name { get { return "Meteor Crash"; } }
        public override int Rarity { get { return 5; } }
        public override int NumberOfHits { get { return 2; } }
    }
}
