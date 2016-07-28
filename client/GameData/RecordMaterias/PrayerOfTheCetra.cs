using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class PrayerOfTheCetra : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111070040; } }
        public override string Name { get { return "Prayer of the Cetra"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.Element == SchemaConstants.ElementID.Holy && ability.Formula != SchemaConstants.Formulas.Healing)
            {
                return 1.1;
            }
            return 1.0;
        }
    }
}
