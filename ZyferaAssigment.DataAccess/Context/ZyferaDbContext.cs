using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyferaAssigment.Entity.Concrete;

namespace ZyferaAssigment.DataAccess.Context
{
    public class ZyferaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server = (localdb)\MSSQLLocalDB;
                Database = ZyferaAssigment;
                Trusted_Connection = True"
               );

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
