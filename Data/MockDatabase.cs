using System.Collections.Generic;
using Business;

namespace Data
{
    public class MockDatabase : IDatabaseWrapper
    {
        public MockDatabase()
        {
            Categories = new List<Category>();
            Records = new List<Record>();
            AuditLogs = new List<string>();
        }

        public List<Category> Categories { get; set; }

        public List<Record> Records { get; set; }

        public List<string> AuditLogs { get; set; }

        public void CreateAudit(string details)
        {
            AuditLogs.Add(details);
        }

        public void CreateCategory(Category category)
        {
            Categories.Add(category);
        }

        public void CreateRecord(Record record)
        {
            Records.Add(record);
        }

        public List<Record> GetAllRecords()
        {
            return Records;
        }

        public List<Category> GetCategories()
        {
            return Categories;
        }
    }
}
