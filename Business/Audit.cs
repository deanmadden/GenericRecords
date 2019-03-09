using System.Text;

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
            StringBuilder auditMessage = new StringBuilder();
            auditMessage.Append($"Added record type {record.Category.Name}");

            foreach (var item in record.Entries)
            {
                auditMessage.Append($", {item.Key}={item.Value}");
            }

            auditMessage.Append(".");

            this.Message = auditMessage.ToString();

            dbWrapper.CreateAudit(this);
        }

        /// <summary>
        /// Updates the specified old record.
        /// </summary>
        /// <param name="oldRecord">The old record.</param>
        /// <param name="newRecord">The new record.</param>
        public void Update(Record oldRecord, Record newRecord)
        {
            StringBuilder auditMessage = new StringBuilder();
            auditMessage.Append($"Amended record type {oldRecord.Category.Name}. Old:");

            foreach (var item in oldRecord.Entries)
            {
                auditMessage.Append($" {item.Key}={item.Value}");
            }

            auditMessage.Append($" New:");

            foreach (var item in newRecord.Entries)
            {
                auditMessage.Append($" {item.Key}={item.Value}");
            }

            auditMessage.Append(".");

            this.Message = auditMessage.ToString();

            dbWrapper.CreateAudit(this);
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
