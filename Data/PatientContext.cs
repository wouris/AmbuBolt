using AmbuBolt.Models;
using Microsoft.EntityFrameworkCore;

namespace AmbuBolt.Data
{
    public class PatientContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public PatientContext(DbContextOptions<PatientContext> options)
            : base(options)
        {
            
        }
    }
}
