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
    public class InstructorManager:IInstructorService
    {
        IInstructorDal instructorDal;
        public InstructorManager(IInstructorDal _instructorDal)
        {
            instructorDal = _instructorDal;
        }

        public void Create(Instructor instructor)
        {
            instructorDal.Create(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            instructorDal.Update(instructor);
        }
    }
}
