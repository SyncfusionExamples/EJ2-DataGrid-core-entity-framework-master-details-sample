using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OrderDbContext: DbContext
    {
        public virtual DbSet<Orders> Orders { get; set; }

        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        public virtual DbSet<Categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\DhivyaRajendran\Downloads\WebApp\WebApp\WebApp\AppData\NORTHWND.MDF';Integrated Security=True");
            }
        }
    }
}
