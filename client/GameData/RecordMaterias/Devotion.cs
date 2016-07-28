using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class Devotion : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111090031; } }
        public override string Name { get { return "Devotion"; } }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.2;
        }

        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 0.9;
        }

        public override double ResModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 0.9;
        }
    }
}
