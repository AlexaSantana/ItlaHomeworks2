using Daycare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Daycare.Infrastructure.Context
{
    public class DayCareContext : DbContext
    {
        public DayCareContext(DbContextOptions<DayCareContext> options)
            : base(options)
        {
        }

        public DbSet<Infante> Infantes { get; set; } = null!;
        public DbSet<Tutor> Tutores { get; set; } = null!;
        public DbSet<Actividad> Actividades { get; set; } = null!;
        public DbSet<Mensaje> Mensajes { get; set; } = null!;
        public DbSet<Asistencia> Asistencias { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
