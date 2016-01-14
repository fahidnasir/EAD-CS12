using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Database
{
    public class CodeFirstDatabaseInitializer : DropCreateDatabaseIfModelChanges<CFDbContext>
    {
        protected override void Seed(CFDbContext context)
        {
            context.Users.Add(new Models.User() { Email = "admin@admin.com", Name = "Admin" });
            base.Seed(context);
        }
    }
}
