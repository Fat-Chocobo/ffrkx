using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class SummonersResolve : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111100121; } }
        public override string Name { get { return "Summoner's Resolve"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Category == SchemaConstants.AbilityCategory.Summoning)
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
