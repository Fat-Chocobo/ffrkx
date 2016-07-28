using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class BoxStepSarabande : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30251022; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Dancer; } }
        public override string Name { get { return "Box Step Sarabande"; } }
        public override int Rarity { get { return 4; } }
    }
}
