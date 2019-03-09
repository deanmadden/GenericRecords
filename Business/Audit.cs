namespace Business
{
    /// <summary>
    /// Audit
    /// </summary>
    public class Audit
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        private IDatabaseWrapper dbWrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Audit"/> class.
        /// </summary>
        public Audit()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Audit" /> class.
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

            foreach (var item in record.Entries)
            {
                auditMessage += $", {item.Key}={item.Value}";
            }

            auditMessage += ".";

            this.Message = auditMessage;

            dbWrapper.CreateAudit(this);
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
