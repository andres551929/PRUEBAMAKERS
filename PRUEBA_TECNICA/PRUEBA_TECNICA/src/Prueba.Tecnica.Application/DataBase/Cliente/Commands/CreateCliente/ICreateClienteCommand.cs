namespace Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente
{
    public interface ICreateClienteCommand
    {
        Task<CreateClienteModel> Execute(CreateClienteModel model);

    }
}
