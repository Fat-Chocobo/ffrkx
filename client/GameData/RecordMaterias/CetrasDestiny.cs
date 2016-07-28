using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class CetrasDestiny : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111070042; } }
        public override string Name { get { return "Cetra's Destiny"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.WhiteMagic && ability.Formula == SchemaConstants.Formulas.Healing)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
