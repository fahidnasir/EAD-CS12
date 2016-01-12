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
            base.Seed(context);
        }
    }
}
