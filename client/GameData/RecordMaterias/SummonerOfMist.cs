using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class SummonerOfMist : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111040042; } }
        public override string Name { get { return "Summoner Of Mist"; } }

        public override double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            if (weapon != null && weapon.Category == SchemaConstants.EquipmentCategory.Whip)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
