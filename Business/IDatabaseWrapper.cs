using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Database Wrapper interface
    /// </summary>
    public interface IDatabaseWrapper
    {
        /// <summary>
        /// Gets the categories.
        /// </summary>
        /// <returns></returns>
        IList<Category> GetCategories();

        /// <summary>
        /// Gets all records.
        /// </summary>
        /// <returns></returns>
        IList<Record> GetAllRecords();

        /// <summary>
        /// Creates the category.
        /// </summary>
        /// <param name="category">The category.</param>
        void CreateCategory(Category category);

        /// <summary>
        /// Creates the record.
        /// </summary>
        /// <param name="record">The record.</param>
        void CreateRecord(Record record);

        /// <summary>
        /// Creates the audit.
        /// </summary>
        /// <param name="details">The details.</param>
        void CreateAudit(Audit audit);

        /// <summary>
        /// Gets the audit records.
        /// </summary>
        /// <returns></returns>
        IList<Audit> GetAuditRecords();
    }
}
