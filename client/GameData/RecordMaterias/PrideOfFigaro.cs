using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class PrideOfFigaro : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111060061; } }
        public override string Name { get { return "Pride of Figaro"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Spear && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
