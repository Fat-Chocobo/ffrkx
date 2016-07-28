using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class AirRaid : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111070112; } }
        public override string Name { get { return "Air Raid"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Element == SchemaConstants.ElementID.Wind && ability.Formula != SchemaConstants.Formulas.Healing)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
