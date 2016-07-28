using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class SamuraiOfDoma : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111060092; } }
        public override string Name { get { return "Samurai of Doma"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Samurai)
            {
                return 1.3;
            }
            return 1.0;
        }
    }
}
