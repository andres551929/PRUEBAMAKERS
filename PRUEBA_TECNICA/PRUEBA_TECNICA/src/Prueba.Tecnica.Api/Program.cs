using Prueba.Tecnica.Api;
using Prueba.Tecnica.Application;
using Prueba.Tecnica.Common;
using Prueba.Tecnica.External;
using Prueba.Tecnica.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


// Add services to the container.

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();
//// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    c.RoutePrefix = string.Empty;
});
app.UseAuthentication(); // JWT

app.UseAuthorization();
app.MapControllers();
app.Run();

