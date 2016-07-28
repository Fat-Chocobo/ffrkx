using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class WhiteShepherd : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111020050; } }
        public override string Name { get { return "White Shepherd"; } }

        public override double MndModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Staff)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
