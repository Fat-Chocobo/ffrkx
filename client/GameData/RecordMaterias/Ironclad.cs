using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class Ironclad : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111090040; } }
        public override string Name { get { return "Ironclad"; } }

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
