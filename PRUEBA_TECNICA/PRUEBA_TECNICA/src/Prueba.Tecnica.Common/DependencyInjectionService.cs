using Microsoft.Extensions.DependencyInjection;

namespace Prueba.Tecnica.Common
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
            return services;
        }
    }
}

