using KodlamaIO.Business.Abstracts;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public void Create(Category category)
        {
            categoryDal.Create(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
