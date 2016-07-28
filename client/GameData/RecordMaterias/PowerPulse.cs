using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class PowerPulse : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111130061; } }
        public override string Name { get { return "Power Pulse"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Dragoon)
            {
                return 1.3;
            }
            return 1.0;
        }
    }
}
