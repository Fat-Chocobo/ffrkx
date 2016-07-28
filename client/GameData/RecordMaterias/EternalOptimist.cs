using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class EternalOptimist : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111130022; } }
        public override string Name { get { return "Eternal Optimist"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Fist)
            {
                return 1.1;
            }
            return 1.0;
        }

        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Fist)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
