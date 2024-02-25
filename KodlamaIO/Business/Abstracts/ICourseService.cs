using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Create(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
