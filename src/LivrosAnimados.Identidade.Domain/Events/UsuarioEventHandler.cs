using LivrosAnimados.Core.Communication.Mediator;
using LivrosAnimados.Identidade.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Events
{
    public class UsuarioEventHandler : INotificationHandler<CriarUsuarioEvent>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediatorHandler _mediatorHandler;

        public Task Handle(CriarUsuarioEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
