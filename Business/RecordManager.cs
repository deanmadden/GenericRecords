﻿using System.Collections.Generic;

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
            Audit audit = new Audit(dbWrapper);
            audit.Create(record);
        }

        /// <summary>
        /// Edits the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void Edit(Record record)
        {
            var oldRecord = dbWrapper.GetRecordById(record.Id);
            dbWrapper.EditRecord(record);
            Audit audit = new Audit(dbWrapper);
            audit.Update(oldRecord, record);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IList<Record> GetAll()
        {
            return dbWrapper.GetAllRecords();
        }
    }
}
