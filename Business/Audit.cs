namespace Business
{
    /// <summary>
    /// Audit
    /// </summary>
    public class Audit
    {
        private IDatabaseWrapper dbWrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Audit"/> class.
        /// </summary>
        /// <param name="databaseWrapper">The database wrapper.</param>
        public Audit(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        /// <summary>
        /// Creates the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void Create(Record record)
        {
            string auditMessage = $"Added record type {record.Category.Name}";

            foreach (string key in record.Entries)
            {
                auditMessage += $", {key}={record.Entries[key]}";
            }

            auditMessage += ".";

            dbWrapper.CreateAudit(auditMessage);
        }

        /// <summary>
        /// Updates the specified old record.
        /// </summary>
        /// <param name="oldRecord">The old record.</param>
        /// <param name="newRecord">The new record.</param>
        public void Update(Record oldRecord, Record newRecord)
        {

        }

        /// <summary>
        /// Deletes the specified record.
        /// </summary>
        /// <param name="record">The record.</param>
        public void Delete(Record record)
        {

        }
    }
}
