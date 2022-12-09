using ekz2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz2.ViewModel
{
    class ApplicationContext : DbContext
    {
        public DbSet<Customer4> Customers { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PC305\\SQLEXPRESS;database=DanyloBodnarsPurchaseNSale;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
