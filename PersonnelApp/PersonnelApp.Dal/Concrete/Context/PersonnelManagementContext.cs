using Microsoft.EntityFrameworkCore;
using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Model.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Concrete.Context
{
    public class PersonnelManagementContext:DbContext
    {
        public PersonnelManagementContext(){}
        public PersonnelManagementContext(DbContextOptions<PersonnelManagementContext> options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IVTV8O4\\SQLEXPRESS;Database=PersonnelManagement;integrated security=true");
        }

        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Materials> Material { get; set; }
    }
}
