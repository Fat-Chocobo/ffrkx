using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class HeartOfTheDragoon : RecordMateria
    {
        public override uint RecordMateriaId { get { return 111040030; } }
        public override string Name { get { return "Heart of the Dragoon"; } }

        public override double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            if (ability.IsJumpAttack())
            {
                return 1.2;
            }
            return 1.0;
        }
    }
}
