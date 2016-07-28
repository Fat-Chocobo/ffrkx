using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class DragoonsDetermination : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111020080; } }
        public override string Name { get { return "Dragoon's Determination"; } }

        public override double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.2;
        }
    }
}
