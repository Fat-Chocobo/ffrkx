using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class AxeMaster : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111000330; } }
        public override string Name { get { return "Axe Master"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Axe && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
