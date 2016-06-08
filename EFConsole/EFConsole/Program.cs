using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContosoUniversityEntities())
            {
                //Console.WriteLine("\t");
                //Console.WriteLine("demo1-------------------\t");
                //foreach (var item in db.Course)
                //{
                //    Console.WriteLine(item.Title + "\t" + item.DepartmentID);

                //}
                //Console.WriteLine("\t");
                //Console.WriteLine("demo2-------------------\t");
                //foreach (var item in db.Department)
                //{
                //    Console.WriteLine(item.Name);
                //    foreach (var course in item.Course)
                //    {
                //        Console.WriteLine("\t" + course.Title);
                //    }
                //}


                Console.WriteLine("\t");
                Console.WriteLine("demo3-------------------\t");

                var newCouse = new Course()
                {
                    CourseID = 8,
                    Title = "EF",
                    Credits = 1,
                    DepartmentID = 2,
                    CreateOn = DateTime.Now

                };
                db.Course.Add(newCouse);
                var c = db.Course.Find(8);
                c.ModifyOn = DateTime.Now;
                db.SaveChanges();

                
            }
        }
    }
}
