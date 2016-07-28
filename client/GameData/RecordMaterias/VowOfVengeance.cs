using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class VowOfVengeance : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111120056; } }
        public override string Name { get { return "Vow of Vengeance"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 0.9;
        }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.1;
        }
    }
}
