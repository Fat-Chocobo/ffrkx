using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class WitchOfSuccession : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111080021; } }
        public override string Name { get { return "Witch of Succession"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.BlackMagic)
            {
                return 1.15;
            }
            return 1.0;
        }
    }
}
