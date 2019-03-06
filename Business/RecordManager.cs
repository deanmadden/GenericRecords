using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RecordManager
    {
        private IDatabaseWrapper dbWrapper;

        public RecordManager(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        public void Create(Record record)
        {
            dbWrapper.CreateRecord(record);
        }
    }
}
