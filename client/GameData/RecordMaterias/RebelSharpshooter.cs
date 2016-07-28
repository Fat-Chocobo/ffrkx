using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class RebelSharpshooter : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111020021; } }
        public override string Name { get { return "Rebel Sharpshooter"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Bow && 
                (ability.Category == SchemaConstants.AbilityCategory.BlackMagic || ability.Formula == SchemaConstants.Formulas.Physical))
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
