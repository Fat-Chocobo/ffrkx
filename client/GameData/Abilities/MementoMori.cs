using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class MementoMori : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30271031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Darkness; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override int MinimumDamage { get { return 800; } }
        public override double Multiplier { get { return 8.0; } }
        public override string Name { get { return "Memento Mori"; } }
        public override int Rarity { get { return 4; } }
    }
}
