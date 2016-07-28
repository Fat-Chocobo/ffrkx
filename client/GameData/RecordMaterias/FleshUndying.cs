using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class FleshUndying : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111070080; } }
        public override string Name { get { return "Flesh Undying"; } }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Gun)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
