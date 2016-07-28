using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class BlackMagicAdept : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111040090; } }
        public override string Name { get { return "Black Magic Adept"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Dagger && ability.Category == SchemaConstants.AbilityCategory.BlackMagic)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
