using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFRKInspector.GameData;

namespace FFRKInspector.GameData.Party
{
    class DataRecordMateriaInformation
    {
        [JsonProperty("record_materia_id")]
        public uint RecordMateriaId;

        [JsonProperty("name")]
        public string Name;

        private RecordMateria mRecordMateria;

        private RecordMateria recordMateria
        {
            get
            {
                if (mRecordMateria != null)
                {
                    return mRecordMateria;
                }
                mRecordMateria = RecordMateria.Find(RecordMateriaId);
                return mRecordMateria;
            }
        }

        public double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return recordMateria.AtkModifier(weapon, armor, accessory);
        }

        public double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return recordMateria.MagModifier(weapon, armor, accessory);
        }

        public double MndModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return recordMateria.MndModifier(weapon, armor, accessory);
        }

        public double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return recordMateria.DefModifier(weapon, armor, accessory);
        }

        public double ResModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return recordMateria.ResModifier(weapon, armor, accessory);
        }

        public double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            return recordMateria.AbilityModifier(weapon, armor, accessory, ability);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
