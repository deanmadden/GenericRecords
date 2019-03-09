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
            AuditLogs = new List<Audit>();
        }

        public IList<Category> Categories { get; set; }

        public IList<Record> Records { get; set; }

        public IList<Audit> AuditLogs { get; set; }

        public void CreateAudit(Audit audit)
        {
            AuditLogs.Add(audit);
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

        public IList<Audit> GetAuditRecords()
        {
            return AuditLogs.ToList();
        }

        public IList<Category> GetCategories()
        {
            return Categories.ToList();
        }
    }
}
