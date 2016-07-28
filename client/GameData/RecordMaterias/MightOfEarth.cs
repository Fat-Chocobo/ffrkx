using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class MightOfEarth : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111039960; } }
        public override string Name { get { return "Might of Earth"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Element == SchemaConstants.ElementID.Earth)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
