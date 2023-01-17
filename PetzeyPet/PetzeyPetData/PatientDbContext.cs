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
            //optionsBuilder.UseSqlServer("Server=tcp:petzeyserverdb.database.windows.net,1433;Initial Catalog=petzeydatabase;Persist Security Info=False;User ID=petzey;Password=password@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Patient_Database;Integrated Security=True");
            // optionsBuilder.
            //optionsBuilder.UseSqlServer("Server=tcp:petzeyserverdb.database.windows.net,1433;Initial Catalog=petzeydatabase;Persist Security Info=False;User ID=petzey;Password=password@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            optionsBuilder.UseSqlServer("Server=tcp:petzeyserverdb.database.windows.net,1433;Initial Catalog=petzeypet;Persist Security Info=False;User ID=petzey;Password=password@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            
        }
        public DbSet<Patient> Patients { get; set; }

    }
}
