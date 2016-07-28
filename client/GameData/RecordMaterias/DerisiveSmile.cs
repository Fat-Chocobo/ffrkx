using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class DerisiveSmile : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111140050; } }
        public override string Name { get { return "Derisive Smile"; } }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Rod)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
