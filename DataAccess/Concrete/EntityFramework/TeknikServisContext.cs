using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class TeknikServisContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=B\SQLSERVER;Database=TeknikServis;Trusted_Connection=True;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
