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
            int id = Categories.Count;
            category.Id = id;
            Categories.Add(category);
        }

        public void CreateRecord(Record record)
        {
            int id = Records.Count;
            record.Id = id;
            Records.Add(record);
        }

        public void EditRecord(Record record)
        {
            var editRecord = GetRecordById(record.Id);

            if (editRecord != null)
            {
                editRecord = record;
            }
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

        public Record GetRecordById(int id)
        {
            return Records.SingleOrDefault(x => x.Id == id);
        }
    }
}
