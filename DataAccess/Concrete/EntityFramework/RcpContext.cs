using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RcpContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KIJEAHG\SQLEXPRESS;Database=MyProject;Trusted_Connection=true");

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarProps> Cars { get; set; }
        public DbSet<Colour> Colours { get; set; }

    }
}
