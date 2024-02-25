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
    public class CourseManager:ICourseService
    {
        ICourseDal courseDal;
        public CourseManager(ICourseDal _courseDal)
        {
            courseDal = _courseDal;
        }

        public void Create(Course course)
        {
            courseDal.Create(course);
        }

        public void Delete(Course course)
        {
            courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            if(courseDal != null)
            {
                return courseDal.GetAll();
            }
            return null;
        }

        public void Update(Course course)
        {
            courseDal.Update(course);
        }
    }
}
