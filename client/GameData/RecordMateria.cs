using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    abstract class RecordMateria
    {
        public virtual uint RecordMateriaId { get { return 0; } }
        public abstract string Name { get; }

        private static List<RecordMateria> mRecordMaterias = null;
        public static List<RecordMateria> AllRecordMaterias()
        {
            if (mRecordMaterias != null)
            {
                return mRecordMaterias;
            }
            mRecordMaterias = new List<RecordMateria>();
            var recordMaterias = System.Reflection.Assembly
                 .GetExecutingAssembly()
                 .GetTypes().Where(t => t.Namespace != null && t.Namespace.StartsWith("FFRKInspector.GameData.RecordMateria") && t.Name != "NullRecordMateria");
            foreach (var recordMateria in recordMaterias)
            {
                mRecordMaterias.Add((RecordMateria)Activator.CreateInstance(recordMateria));
            }
            mRecordMaterias = mRecordMaterias.OrderBy(recordMateria => recordMateria.Name).ToList();
            return mRecordMaterias;
        }

        public static RecordMateria Find(uint recordMateriaId)
        {
            RecordMateria recordMateria = AllRecordMaterias().Where(rm => rm.RecordMateriaId == recordMateriaId).FirstOrDefault();
            if (recordMateria == null || recordMateria.Equals(default(RecordMateria)))
            {
                return new RecordMaterias.NullRecordMateria();
            }

            return recordMateria;

        }
        
        public override string ToString()
        {
            return Name;
        }

        public virtual double AtkModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.0;
        }

        public virtual double MagModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.0;
        }

        public virtual double MndModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.0;
        }

        public virtual double DefModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.0;
        }

        public virtual double ResModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory)
        {
            return 1.0;
        }

        public virtual double AbilityModifier(Party.DataEquipmentInformation weapon, Party.DataEquipmentInformation armor, Party.DataEquipmentInformation accessory, Ability ability)
        {
            return 1.0;
        }


    }
}
