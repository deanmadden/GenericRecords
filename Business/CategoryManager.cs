using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Category Manager
    /// </summary>
    public class CategoryManager
    {
        private IDatabaseWrapper dbWrapper;

        public CategoryManager(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        public void Create(Category category)
        {
            dbWrapper.CreateCategory(category);
        }

        public List<Category> GetAll()
        {
            return dbWrapper.GetCategories();
        }
    }
}
