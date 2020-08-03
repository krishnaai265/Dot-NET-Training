using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCEntity9.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { set; get; }
    }
    
}