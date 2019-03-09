using Business;
using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class LiteDBWrapper : IDatabaseWrapper
    {
        private const string dbstring = @"C:\Temp\GenericRecordsData.db";

        public void CreateAudit(Audit audit)
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var audits = db.GetCollection<Audit>("audits");
                audits.Insert(audit);
            }
        }

        public void CreateCategory(Category category)
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var categories = db.GetCollection<Category>("categories");
                categories.Insert(category);
            }
        }

        public void CreateRecord(Record record)
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var records = db.GetCollection<Record>(dbstring);
                records.Insert(record);
            }
        }

        public IList<Record> GetAllRecords()
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var records = db.GetCollection<Record>("records");
                return records.FindAll().ToList();
            }
        }

        public IList<Category> GetCategories()
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var categories = db.GetCollection<Category>("categories");
                return categories.FindAll().ToList();
            }
        }

        public IList<Audit> GetAuditRecords()
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var audits = db.GetCollection<Audit>("audits");
                return audits.FindAll().ToList();
            }
        }

        public void EditRecord(Record record)
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var editRecord = GetRecordById(record.Id);

                if (editRecord != null)
                {
                    var records = db.GetCollection<Record>("records");
                    records.Update(record);
                }
            }
        }

        public Record GetRecordById(int id)
        {
            using (var db = new LiteDatabase(dbstring))
            {
                var records = db.GetCollection<Record>("records");
                return records.FindById(id);
            }
        }
    }
}
