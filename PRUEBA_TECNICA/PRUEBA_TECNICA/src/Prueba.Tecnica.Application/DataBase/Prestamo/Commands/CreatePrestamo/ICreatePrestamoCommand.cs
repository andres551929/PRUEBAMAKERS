using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo
{
    public interface ICreatePrestamoCommand
    {
        Task<CreatePrestamoModel> Execute(CreatePrestamoModel model);

    }
}
