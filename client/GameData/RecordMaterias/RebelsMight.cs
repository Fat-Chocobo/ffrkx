using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class RebelsMight : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111020011; } }
        public override string Name { get { return "Rebel's Might"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.1;
        }
        
        public override double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.1;
        }
    }
}
