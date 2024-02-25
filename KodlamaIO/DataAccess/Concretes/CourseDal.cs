using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı";
            course1.CourseDescription = "NET 6 üzerinde, clean architecture, CQRS, event güdümlü geliştirme, birim testleri, code first geliştirme, docker ve çok daha fazlasını içeren 2 aylık ileri bir kamp sizi bekliyor. Yine ücretsiz.";
            course1.CoursePrice = 0;
            
            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "";
            course2.CourseDescription = " ";
            course2.CoursePrice = 0;

            Course course3 = new Course();
            course3.CourseId = 3;
            course3.CourseName = "";
            course3.CourseDescription = "";
            course3.CoursePrice = 0;

            Course course4 = new Course();
            course4.CourseId = 4;
            course4.CourseName = "";
            course4.CourseDescription = "";
            course4.CoursePrice = 0;

            Course course5 = new Course();
            course5.CourseId = 5;
            course5.CourseName = "";
            course5.CourseDescription = "";
            course5.CoursePrice = 0;

            Course course6 = new Course();
            course6.CourseId = 6;
            course6.CourseName = "";
            course6.CourseDescription = "";
            course6.CoursePrice = 0;

            Course course7 = new Course();
            course7.CourseId = 7;
            course7.CourseName = "";
            course7.CourseDescription = " ";
            course7.CoursePrice = 0;

            Course course8 = new Course();
            course8.CourseId = 8;
            course8.CourseName = "";
            course8.CourseDescription = "";
            course8.CoursePrice = 0;

            courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8};
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public void Create (Course course)
        {
            int sayac = 0;
            foreach (var item in courses)
            {
                if  (item == course)
                {
                    sayac++;
                }
            }
            if(sayac == 0)
            {
                courses.Add(course);
                Console.WriteLine("Kurs başarı ile eklendi.");
            }
            else
            {
                Console.WriteLine("Ekli olan bir kursu ekleyemezsiniz.");
            }
        }
        public void Delete(Course course)
        {
            int sayac = 1;
            foreach (var item in courses)
            {
                if (item == course)
                {
                    courses.Remove(course);
                    sayac--;
                }
            }
            if(sayac == 0)
            {
                Console.WriteLine("Kurs başarı ile silindi.");
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz kurs sistemimizde zaten kayıtlı değil!!");
            }
        }
        public void Update(Course course)
        {
            int sayac = 1;
            foreach (var item in courses)
            {
                if (item.CourseId == course.CourseId)
                {
                    courses.Remove(course);
                    sayac--;
                }
            }
            if (sayac == 0)
            {
                courses.Add(course);
                Console.WriteLine("Kurs başarı ile güncellendi.");
            }
            else
            {
                Console.WriteLine("Güncellemek istediğiniz kurs sistemimizde zaten kayıtlı değil!!");
            }
        }
    }
}
