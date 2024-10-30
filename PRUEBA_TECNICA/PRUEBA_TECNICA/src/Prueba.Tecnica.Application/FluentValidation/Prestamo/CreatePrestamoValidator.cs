using FluentValidation;
using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;
using Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Application.FluentValidation.Prestamo
{
    public class CreatePrestamoValidator : AbstractValidator<CreatePrestamoModel>
    {
        public CreatePrestamoValidator()
        {
            RuleFor(x => x.CLIE_ID).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty();
            RuleFor(x => x.PRES_CANTIDAD).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty();
        }
    }
}
