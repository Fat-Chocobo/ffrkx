using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class BalambFirebrand : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111080042; } }
        public override string Name { get { return "Balamb Firebrand"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Monk)
            {
                return 1.3;
            }
            return 1.0;
        }
    }
}
