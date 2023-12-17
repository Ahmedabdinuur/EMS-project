using Microsoft.EntityFrameworkCore;
using EMS.Model;

namespace EMS.MyDB
{
    internal class ContextDB:DbContext
    {
        public DbSet<Employee> Employes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=employees.db");
        }
    }
}