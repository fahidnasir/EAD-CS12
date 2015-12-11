using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignupSigninMVCExample.Models
{
    public class SignupSigninMVCExampleContext : DbContext
    {    
        public SignupSigninMVCExampleContext() : base("name=SignupSigninMVCExampleContext")
        {
        }

        public System.Data.Entity.DbSet<User> Users { get; set; }
    
    }
}
