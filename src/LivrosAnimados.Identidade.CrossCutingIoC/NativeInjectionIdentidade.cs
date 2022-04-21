using EventSourcing;
using LivrosAnimados.Core.Communication.Mediator;
using LivrosAnimados.Core.Data.EventSourcing;
using LivrosAnimados.Core.Messages.CommonMessages.Notifications;
using LivrosAnimados.Identidade.Domain.Interfaces;
using LivrosAnimados.Identidade.Domain.Services;
using LivrosAnimados.Identidade.Repository;
using LivrosAnimados.Identidade.Repository.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LivrosAnimados.Identidade.CrossCutingIoC
{
    public class NativeInjectionIdentidade
    {
        public static void ConfigurarDependencias(IServiceCollection services)
        {
            services.AddDbContext<IdentidadeContext>();

            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Event Sourcing
            services.AddSingleton<IEventStoreService, EventStoreService>();
            services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

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
