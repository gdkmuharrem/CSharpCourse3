using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        void Create (Instructor instructor);
        void Update (Instructor instructor);
        void Delete (Instructor instructor);
    }
}
