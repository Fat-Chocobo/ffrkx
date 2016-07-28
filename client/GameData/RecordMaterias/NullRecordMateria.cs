using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.RecordMaterias
{
    class NullRecordMateria : RecordMateria
    {
        public override uint RecordMateriaId { get { return 0; } }
        public override string Name { get { return "Null"; } }
    }
}
