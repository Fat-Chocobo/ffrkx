using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class CulturedConjurer : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111140010; } }
        public override string Name { get { return "Cultured Conjurer"; } }

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
