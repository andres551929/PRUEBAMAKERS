using FluentValidation;
using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;

namespace Prueba.Tecnica.Application.FluentValidation.Cliente
{
    public class CreateClienteValidator : AbstractValidator<CreateClienteModel>
    {
        public CreateClienteValidator()
        {
            RuleFor(x => x.CLIE_NOMBRE).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty().MaximumLength(50);
        }
    }
}
