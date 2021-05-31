using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApp.Models;

namespace WebApp.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base(nameOrConnectionString: "MyConnection")
        {
        }

        public virtual DbSet<StudentClass> StudentObj { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Rooms> Rooms { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Groups> Groups { get; set; }

        //public System.Data.Entity.DbSet<NextTry.Models.DocumentType> DocumentTypes { get; set; }

        //public System.Data.Entity.DbSet<NextTry.Models.Document> Documents { get; set; }
    }
}