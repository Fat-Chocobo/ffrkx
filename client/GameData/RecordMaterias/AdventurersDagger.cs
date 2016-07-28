using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class AdventurersDagger : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111060031; } }
        public override string Name { get { return "Adventurer's Dagger"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Dagger && ability.Formula == SchemaConstants.Formulas.Physical)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
