using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class FeralMight : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111060101; } }
        public override string Name { get { return "Feral Might"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.1;
        }
    }
}
