using Microsoft.EntityFrameworkCore;
using Prueba.Tecnica.Application.DataBase;
using Prueba.Tecnica.Domain.Entities.Cliente;
using Prueba.Tecnica.Domain.Entities.Prestamo;
using Prueba.Tecnica.Persistence.DataBase.Configuration;

namespace Prueba.Tecnica.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<PrestamoEntity> Prestamo { get; set; }



        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new ClienteConfiguration(modelBuilder.Entity<ClienteEntity>());
            new PrestamoConfiguration(modelBuilder.Entity<PrestamoEntity>());

        }
    }
}
