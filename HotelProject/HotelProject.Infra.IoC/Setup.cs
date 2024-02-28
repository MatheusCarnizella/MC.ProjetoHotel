using HotelProject.Application.Query.Usuario;
using HotelProject.Domain.Repositories.Usuario;
using HotelProject.Infra.Repository.Usuario;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.Infra.IoC
{
    public static class Setup
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            services.AddScoped<GetUsuarioQuery>();
        }
    }
}
