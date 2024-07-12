using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProyectoFraccionamiento.Entities;

namespace ProyectoFraccionamientoFinal
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<VehiculoEntity> Vehiculos => Set<VehiculoEntity>();
        public DbSet <VisitaEntity> Visitas => Set<VisitaEntity>();
        public DbSet <SocialAreaEntity> AreasSociales=> Set<SocialAreaEntity>();

    }
}
