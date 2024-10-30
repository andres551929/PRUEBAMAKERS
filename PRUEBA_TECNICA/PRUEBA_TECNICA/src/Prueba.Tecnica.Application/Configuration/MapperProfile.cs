using AutoMapper;
using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;
using Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo;
using Prueba.Tecnica.Domain.Entities.Cliente;
using Prueba.Tecnica.Domain.Entities.Prestamo;

namespace Prueba.Tecnica.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClienteEntity, CreateClienteModel>().ReverseMap();
            CreateMap<PrestamoEntity, CreatePrestamoModel>().ReverseMap();

        }
    }
}
