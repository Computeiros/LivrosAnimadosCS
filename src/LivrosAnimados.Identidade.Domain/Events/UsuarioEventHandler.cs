using LivrosAnimados.Core.Communication.Mediator;
using LivrosAnimados.Core.DomainObjects;
using LivrosAnimados.Identidade.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Events
{
    public class UsuarioEventHandler : INotificationHandler<CriarUsuarioEvent>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMediatorHandler _mediatorHandler;

        public UsuarioEventHandler(IUsuarioRepository usuarioRepository, IMediatorHandler mediatorHandler)
        {
            _usuarioRepository = usuarioRepository;
            _mediatorHandler = mediatorHandler;
        }

        public async Task Handle(CriarUsuarioEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Usuario is null)
                throw new DomainException();

            _usuarioRepository.Adicionar(notification.Usuario);

            await _usuarioRepository.UnitOfWork.Commit();
        }
    }
}
