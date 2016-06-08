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
            #region mark
            //using (var db = new ContosoUniversityEntities())
            //{

            #region demo1 利用EF撈資料
            //Console.WriteLine("\t");
            //Console.WriteLine("demo1-------------------\t");
            //foreach (var item in db.Course)
            //{
            //    Console.WriteLine(item.Title + "\t" + item.DepartmentID);

            //}
            #endregion

            #region demo2 利用EF撈資料(1對多)
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
            #endregion

            #region dmmo3 CU data
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
            #endregion

            #region demo4 trace sql
            //Console.WriteLine("\t");
            //Console.WriteLine("demo4: trace sql-------------------\t");
            //db.Database.Log = (msg) =>
            //{
            //    Console.WriteLine(msg);
            //};

            //Console.WriteLine("\t");
            #endregion

            #region demo5 entry.state
            //Console.WriteLine("demo4:狀態-------------------\t");
            //var c = db.Course.Find(8);
            //var ce = db.Entry(c);
            //Console.WriteLine(ce.State);
            ////db.Course.Remove(c);
            ////直接變動狀態也可進行資料異動
            //c.Title = "EF2";
            //db.SaveChanges();
            ////複製
            ////db.Entry(c).State = System.Data.Entity.EntityState.Added;
            #endregion

            //}


            #region demo6 離線
            //    Console.WriteLine("\t");
            //Console.WriteLine("demo5:離線-------------------\t");
            //var d = new Course()
            //{
            //    CourseID = 0,
            //    Title = "EF",
            //    Credits = 1,
            //    DepartmentID = 2,
            //    CreateOn = DateTime.Now.AddDays(1)
            //};

            //using (var db1 = new ContosoUniversityEntities())
            //{
            //    db1.Course.Attach(d);//離線物件變成連線，可以用attach，會有快取的狀況
            //    db1.Entry(d).State = System.Data.Entity.EntityState.Added;
            //    db1.SaveChanges();
            //}
            #endregion

            #region demo7 離線(2個生命週期
            //var c = new Course();
            //using (var db = new ContosoUniversityEntities())
            //{
            //    c = db.Course.Find(8);
            //    c.Credits += 1;
            //}
            //    using (var db1 = new ContosoUniversityEntities())
            //{
            //    db1.Entry(c).State = System.Data.Entity.EntityState.Modified;
            //    db1.SaveChanges();
            //}

            #endregion

            #endregion
            

        }
    }

}