using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class ImpetuousYouth : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111090070; } }
        public override string Name { get { return "Impetuous Youth"; } }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.1;
        }

        public override double ResModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 0.9;
        }
    }
}
