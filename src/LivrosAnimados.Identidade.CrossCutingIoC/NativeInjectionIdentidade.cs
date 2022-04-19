using LivrosAnimados.Identidade.Domain.Interfaces;
using LivrosAnimados.Identidade.Domain.Services;
using LivrosAnimados.Identidade.Repository;
using LivrosAnimados.Identidade.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace LivrosAnimados.Identidade.CrossCutingIoC
{
    public class NativeInjectionIdentidade
    {
        public static void ConfigurarDependencias(IServiceCollection services)
        {
            services.AddDbContext<IdentidadeContext>();

            ConfigurarDependenciasRepository(services);
            ConfigurarDependenciasService(services);
        }

        private static void ConfigurarDependenciasService(IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
        }

        private static void ConfigurarDependenciasRepository(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
