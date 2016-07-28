using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class MightOfWind : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111030010; } }
        public override string Name { get { return "Might of Wind"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Element == SchemaConstants.ElementID.Wind)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
