using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class BurmecianDragonKnight : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111090050; } }
        public override string Name { get { return "Burmecian Dragon Knight"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Dragoon)
            {
                return 1.15;
            }
            return 1.0;
        }
    }
}
