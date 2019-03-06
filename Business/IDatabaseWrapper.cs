using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IDatabaseWrapper
    {
        List<Category> GetCategories();

        void CreateCategory(Category category);

        void CreateRecord(Record record);
    }
}
