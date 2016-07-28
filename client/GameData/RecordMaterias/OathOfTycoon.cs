using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class OathOfTycoon : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111050020; } }
        public override string Name { get { return "Oath of Tycoon"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.WhiteMagic && ability.Formula == SchemaConstants.Formulas.Healing)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
