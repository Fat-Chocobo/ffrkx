using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class SpiritOfSasune : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111030042; } }
        public override string Name { get { return "Spirit of Sasune"; } }

        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (armor != null && armor.Category == SchemaConstants.EquipmentCategory.Shield)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
