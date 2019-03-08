using System.Collections.Generic;
using System.Linq;
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

        public IList<Category> Categories { get; set; }

        public IList<Record> Records { get; set; }

        public IList<string> AuditLogs { get; set; }

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

        public IList<Record> GetAllRecords()
        {
            return Records.ToList();
        }

        public IList<Category> GetCategories()
        {
            return Categories.ToList();
        }
    }
}
