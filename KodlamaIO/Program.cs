using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course
            {
                CourseId = 9,
                CourseName = "Python Dersi",
                CourseDescription = "Python kursu temellerini bu kursta işleyeceğiz.",
                ınstructor = new Instructor { InstructorId = 3 , InstructorFirstName = "Ahmet", InstructorLastName ="Topal" },
                category = new Category { CategoryId = 3, CategoryName = "Yapay Zeka" }
            };


            CourseManager courseManager = new CourseManager(new CourseDal());
            courseManager.Create(course);
            foreach (var item in courseManager.GetAll())
            {
                Console.WriteLine(item.CourseName + " " + item.category.CategoryName + " " + item.ınstructor.InstructorFirstName + " " + item.ınstructor.InstructorLastName);
            }
            Console.ReadLine();
        }
    }
}
