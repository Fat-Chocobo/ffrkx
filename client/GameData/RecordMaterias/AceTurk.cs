using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class AceTurk : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111070121; } }
        public override string Name { get { return "Ace Turk"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Rod && (ability.Formula == SchemaConstants.Formulas.Physical || ability.Category == SchemaConstants.AbilityCategory.BlackMagic))
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
