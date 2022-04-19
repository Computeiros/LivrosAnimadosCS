using LivrosAnimados.Identidade.Domain.Interfaces;
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
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
