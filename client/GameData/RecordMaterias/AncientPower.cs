using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class AncientPower : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111030050; } }
        public override string Name { get { return "Ancient Power"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Sword && ability.Category == SchemaConstants.AbilityCategory.BlackMagic)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
