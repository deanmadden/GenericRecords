using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using LiteDB;

namespace Data
{
    public class LiteDBWrapper : IDatabaseWrapper
    {
        public void CreateAudit(string details)
        {
            throw new NotImplementedException();
        }

        public void CreateCategory(Category category)
        {
            using (var db = new LiteDatabase(@"GenericRecordsData.db"))
            {
                // Get customer collection
                var categories = db.GetCollection<Category>("categories");

                // Insert new customer document (Id will be auto-incremented)
                categories.Insert(category);
            }
        }

        public void CreateRecord(Record record)
        {
            throw new NotImplementedException();
        }

        public IList<Record> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetCategories()
        {
            using (var db = new LiteDatabase(@"GenericRecordsData.db"))
            {
                // Get customer collection
                var categories = db.GetCollection<Category>("categories");

                return categories.FindAll().ToList();
            }
        }
    }
}
