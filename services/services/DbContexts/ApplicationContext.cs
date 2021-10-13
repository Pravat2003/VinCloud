using Microsoft.EntityFrameworkCore;
using services.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace services.DbContexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //   // builder.Entity<Product>();
        //}
        public DbSet<Product> Products { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
