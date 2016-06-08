using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public partial class ContosoUniversityEntities : DbContext
    {
        public override int SaveChanges()
        {
            var entities = this.ChangeTracker.Entries();
            foreach (var entry in entities)
            {
                if (entry.State == EntityState.Modified)
                {
                    if (entry.Entity is Course)
                    {
                        var a = entry.Entity as Course;
                        Console.WriteLine(entry.State);
                        Console.WriteLine(a.Title);
                    }
                    entry.CurrentValues.SetValues(new { ModifyOn = DateTime.Now });
                }
            }
            return base.SaveChanges();
        }
    }

}
