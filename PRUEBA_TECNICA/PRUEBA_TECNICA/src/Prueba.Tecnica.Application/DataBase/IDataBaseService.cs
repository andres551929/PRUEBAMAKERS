using Microsoft.EntityFrameworkCore;
using Prueba.Tecnica.Domain.Entities.Cliente;
using Prueba.Tecnica.Domain.Entities.Prestamo;

namespace Prueba.Tecnica.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<ClienteEntity> Cliente { get; set; }
        DbSet<PrestamoEntity> Prestamo { get; set; }


        Task<bool> SaveAsync();
    }
}
