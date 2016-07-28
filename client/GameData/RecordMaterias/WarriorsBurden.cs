using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class WarriorsBurden : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111050070; } }
        public override string Name { get { return "Warrior's Burden"; } }

        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (armor != null && armor.Category == SchemaConstants.EquipmentCategory.Armor)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
