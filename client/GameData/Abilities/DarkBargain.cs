using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class DarkBargain : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30271001; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Darkness; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Dark; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 2.2; } }
        public override string Name { get { return "Dark Bargain"; } }
        public override int Rarity { get { return 4; } }
    }
}
