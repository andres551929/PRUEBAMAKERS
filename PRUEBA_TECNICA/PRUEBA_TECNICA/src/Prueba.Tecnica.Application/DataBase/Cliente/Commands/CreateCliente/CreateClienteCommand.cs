using AutoMapper;
using Prueba.Tecnica.Domain.Entities.Cliente;

namespace Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente
{
    public class CreateClienteCommand : ICreateClienteCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateClienteCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreateClienteModel> Execute(CreateClienteModel model)
        {
            var entity = _mapper.Map<ClienteEntity>(model);


            await _dataBaseService.Cliente.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
