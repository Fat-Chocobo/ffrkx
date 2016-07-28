using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class ArtemisOfBaron : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111040061; } }
        public override string Name { get { return "Artemis of Baron"; } }

        public override double MndModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Bow)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
