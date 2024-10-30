using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo;
using Prueba.Tecnica.Application.Features;

namespace Prueba.Tecnica.Api.Controllers
{
    [Route("api/v1/prestamo")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreatePrestamoModel model, [FromServices] ICreatePrestamoCommand createPrestamoCommand, [FromServices] IValidator<CreatePrestamoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createPrestamoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
    }
}
