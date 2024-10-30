using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Prueba.Tecnica.Application.Configuration;
using Prueba.Tecnica.Application.DataBase.Cliente.Commands.CreateCliente;
using Prueba.Tecnica.Application.DataBase.Prestamo.Commands.CreatePrestamo;
using Prueba.Tecnica.Application.FluentValidation.Cliente;
using Prueba.Tecnica.Application.FluentValidation.Prestamo;

namespace Prueba.Tecnica.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            services.AddTransient<ICreateClienteCommand, CreateClienteCommand>();
            services.AddTransient<ICreatePrestamoCommand, CreatePrestamoCommand>();


            #region Validator
            services.AddScoped<IValidator<CreateClienteModel>, CreateClienteValidator>();
            services.AddScoped<IValidator<CreatePrestamoModel>, CreatePrestamoValidator>();

            #endregion
            return services;
        }
    }
}
