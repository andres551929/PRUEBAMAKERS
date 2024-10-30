using AutoMapper;
using Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo;
using Prueba.Tecnica.Domain.Entities.Prestamo;

namespace Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo
{
    public class CreatePrestamoCommand : ICreatePrestamoCommand
    {

        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreatePrestamoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreatePrestamoModel> Execute(CreatePrestamoModel model)
        {
            var entity = _mapper.Map<PrestamoEntity>(model);


            await _dataBaseService.Prestamo.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
