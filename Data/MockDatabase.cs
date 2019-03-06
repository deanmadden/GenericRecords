using System.Collections.Generic;
using System.Collections.Specialized;
using Business;

namespace Data
{
    public class MockDatabase : IDatabaseWrapper
    {
        public List<Category> Categories { get; set; }

        public void CreateCategory(Category category)
        {
            if (Categories == null)
            {
                Categories = new List<Category>();
            }

            Categories.Add(category);
        }

        public List<Category> GetCategories()
        {
            return Categories;
        }
    }
}
