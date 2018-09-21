using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSLChallenge.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SSLChallenge.DAL
{
    public class SSLContext : DbContext
    {
        public SSLContext() : base("SSLContext") { }

        public DbSet<Module> Modules { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}