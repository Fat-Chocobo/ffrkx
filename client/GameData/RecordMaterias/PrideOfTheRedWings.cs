using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class PrideOfTheRedWings : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111040012; } }
        public override string Name { get { return "Pride of the Red Wings"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Sword && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
