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

                //Console.WriteLine("\t");
                //Console.WriteLine("demo3-------------------\t");
                ////新增
                //var newCouse = new Course()
                //{
                //    CourseID = 0,
                //    Title = "EF",
                //    Credits = 1,
                //    DepartmentID = 2,
                //    CreateOn = DateTime.Now.AddDays(1)

                //};
                //db.Course.Add(newCouse);
                ////更新
                //var c = db.Course.Find(8);
                //c.ModifyOn = DateTime.Now;
                //db.SaveChanges();

                //Console.WriteLine("\t");
                //Console.WriteLine("demo4: trace sql-------------------\t");
                //db.Database.Log = (msg) =>
                //{
                //    Console.WriteLine(msg);
                //};

                Console.WriteLine("\t");
                Console.WriteLine("demo4:狀態-------------------\t");
                var c = db.Course.Find(8);
                var ce = db.Entry(c);
                Console.WriteLine(ce.State);
                //db.Course.Remove(c);
                //直接變動狀態也可進行資料異動
                c.Title = "EF2";
                db.SaveChanges();
                //複製
                //db.Entry(c).State = System.Data.Entity.EntityState.Added;
            }
        }
    }
}
