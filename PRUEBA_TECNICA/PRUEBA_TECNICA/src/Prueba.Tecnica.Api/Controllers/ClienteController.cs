using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;
using Prueba.Tecnica.Application.Features;

namespace Prueba.Tecnica.Api.Controllers
{
    [Route("api/v1/contrato")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateClienteModel model, [FromServices] ICreateClienteCommand createClienteCommand, [FromServices] IValidator<CreateClienteModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createClienteCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
    }
}
