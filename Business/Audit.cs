using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Audit
    {
        private IDatabaseWrapper dbWrapper;

        public Audit(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        public void Create(Record record)
        {

        }

        public void Update(Record oldRecord, Record newRecord)
        {

        }

        public void Delete(Record record)
        {

        }
    }
}
