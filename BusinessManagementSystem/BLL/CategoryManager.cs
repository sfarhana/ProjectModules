using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagementSystem.Repository;
using BusinessManagementSystem.Model;
using System.Data;

namespace BusinessManagementSystem.BLL
{
    public class CategoryManager
    {
        CategoryRepository _CR = new CategoryRepository();

        public bool IsCodeUnique(string Code,int CategoryId)
        {
          return _CR.IsCodeUnique(Code, CategoryId);
        }

        public bool IsNameUnique(string Name, int CategoryId)
        {
            return _CR.IsNameUnique(Name, CategoryId);
        }

        public bool InsertCategory(Category ctg)
        {
            return _CR.InsertCategory(ctg);
        }

        public DataTable LoadCategoryInfo()
        {
            return _CR.LoadCategoryInfo();
        }

        public bool UpdateCategory(Category ctg)
        {
            return _CR.UpdateCategory(ctg);
        }

        public DataTable SearchCategoryName(string Name)
        {
            return _CR.SearchCategoryName(Name);
        }
    }
}
