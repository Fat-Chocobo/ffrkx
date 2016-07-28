using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class DarkFate : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111090101; } }
        public override string Name { get { return "Dark Fate"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Element == SchemaConstants.ElementID.Dark)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
