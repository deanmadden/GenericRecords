using System.Collections.Generic;
using Business;

namespace Data
{
    public class MockDatabase : IDatabaseWrapper
    {
        public List<Category> Categories { get; set; }

        public List<Record> Records { get; set; }

        public List<string> AuditLogs { get; set; }

        public void CreateAudit(string details)
        {
            AuditLogs.Add(details);
        }

        public void CreateCategory(Category category)
        {
            if (Categories == null)
            {
                Categories = new List<Category>();
            }

            Categories.Add(category);
        }

        public void CreateRecord(Record record)
        {
            if (Records == null)
            {
                Records = new List<Record>();
            }

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
