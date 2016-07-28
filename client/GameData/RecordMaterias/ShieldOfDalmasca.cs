using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class ShieldOfDalmasca : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111120040; } }
        public override string Name { get { return "Shield of Dalmasca"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (armor != null && armor.Category == SchemaConstants.EquipmentCategory.Shield)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
