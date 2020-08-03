using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirstRealationship.Models
{
    public class AuthorDBContext: DbContext
    {
        public DbSet<Author> author { set; get; }
    }
}