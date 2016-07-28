using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class HonedFlesh : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111140030; } }
        public override string Name { get { return "Honed Flesh"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Monk)
            {
                return 1.15;
            }
            return 1.0;
        }
    }
}
