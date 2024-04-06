using Microsoft.EntityFrameworkCore;

namespace L01P022021CL650.Models
{
    public class notasDBContext : DbContext
    {
        public notasDBContext(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultades> facultades { get; set; }

    }
}
