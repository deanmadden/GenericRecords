using Business;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class LiteDBWrapper : IDatabaseWrapper
    {
        public void CreateAudit(Audit audit)
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var audits = db.GetCollection<Audit>("audits");
                audits.Insert(audit);
            }
        }

        public void CreateCategory(Category category)
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var categories = db.GetCollection<Category>("categories");
                categories.Insert(category);
            }
        }

        public void CreateRecord(Record record)
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var records = db.GetCollection<Record>("records");
                records.Insert(record);
            }
        }

        public IList<Record> GetAllRecords()
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var records = db.GetCollection<Record>("records");
                return records.FindAll().ToList();
            }
        }

        public IList<Category> GetCategories()
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var categories = db.GetCollection<Category>("categories");
                return categories.FindAll().ToList();
            }
        }

        public IList<Audit> GetAuditRecords()
        {
            using (var db = new LiteDatabase(@"C:\Temp\GenericRecordsData.db"))
            {
                var audits = db.GetCollection<Audit>("audits");
                return audits.FindAll().ToList();
            }
        }
    }
}
