using Microsoft.EntityFrameworkCore;
using PetzeyPetDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyPetData
{
    internal class PatientDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Patient_Database;Integrated Security=True");
        }
        public DbSet<Patient> Patients { get; set; }

    }
}
