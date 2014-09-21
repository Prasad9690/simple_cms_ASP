using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class CMSContext : DbContext
    {
        //CRUD Functionality
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Content> Contents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}