using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
