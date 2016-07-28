using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class Bushido : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111100070; } }
        public override string Name { get { return "Bushido"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Katana && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
