using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company_Abdelkader.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_Abdelkader.DAL.Data.Contexts
{
    public class CompanyDbContext : DbContext
    {

        public CompanyDbContext (DbContextOptions<CompanyDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Server = .; Database = Company_Abdelkader; Trusted_Connection = true;TrustServerCertificate = True");
        //}
        public DbSet<Department> Departments { get; set; }
    }
}
