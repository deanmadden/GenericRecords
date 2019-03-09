using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Category Manager
    /// </summary>
    public class CategoryManager
    {
        private IDatabaseWrapper dbWrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryManager"/> class.
        /// </summary>
        /// <param name="databaseWrapper">The database wrapper.</param>
        public CategoryManager(IDatabaseWrapper databaseWrapper)
        {
            dbWrapper = databaseWrapper;
        }

        /// <summary>
        /// Creates the specified category.
        /// </summary>
        /// <param name="category">The category.</param>
        public void Create(Category category)
        {
            dbWrapper.CreateCategory(category);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IList<Category> GetAll()
        {
            return dbWrapper.GetCategories();
        }
    }
}
