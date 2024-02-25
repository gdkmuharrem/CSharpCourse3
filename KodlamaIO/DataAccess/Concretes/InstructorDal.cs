using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.InstructorFirstName = "Engin";
            instructor1.InstructorLastName = "Demiroğ";
            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 2;
            instructor2.InstructorFirstName = "Muharrem";
            instructor2.InstructorLastName = "Gedik";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Create(Instructor instructor)
        {
            int sayac = 0;
            foreach (var item in instructors)
            {
                if (item == instructor)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                instructors.Add(instructor);
                Console.WriteLine("Eğitmen başarı ile eklendi.");
            }
            else
            {
                Console.WriteLine("Ekli olan bir Eğitmeni ekleyemezsiniz.");
            }
        }

        public void Delete(Instructor instructor)
        {
            int sayac = 1;
            foreach (var item in instructors)
            {
                if (item == instructor)
                {
                    instructors.Remove(instructor);
                    sayac--;
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("Eğitmen başarı ile silindi.");
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz Eğitmen sistemimizde zaten kayıtlı değil!!");
            }
        }

        public void Update(Instructor instructor)
        {
            int sayac = 1;
            foreach (var item in instructors)
            {
                if (item.InstructorId == instructor.InstructorId)
                {
                    instructors.Remove(instructor);
                    sayac--;
                }
            }
            if (sayac == 0)
            {
                instructors.Add(instructor);
                Console.WriteLine("Eğitmen başarı ile güncellendi.");
            }
            else
            {
                Console.WriteLine("Güncellemek istediğiniz Eğitmen sistemimizde zaten kayıtlı değil!!");
            }
        }
    }
}
