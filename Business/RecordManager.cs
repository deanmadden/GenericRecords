using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Record Manager
    /// </summary>
    public class RecordManager
    {
        private IDatabaseWrapper dbWrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordManager"/> class.
        /// </summary>
        /// <param name="databaseWrapper">The database wrapper.</param>
        public RecordManager(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        /// <summary>
        /// Creates the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void Create(Record record)
        {
            dbWrapper.CreateRecord(record);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Record> GetAll()
        {
            return dbWrapper.GetAllRecords();
        }
    }
}
