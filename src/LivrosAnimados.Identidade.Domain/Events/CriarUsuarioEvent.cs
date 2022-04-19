using LivrosAnimados.Core.Messages.CommonMessages.DomainEvents;
using LivrosAnimados.Identidade.Domain.Models;

namespace LivrosAnimados.Identidade.Domain.Events
{
    public class CriarUsuarioEvent : DomainEvent
    {
        public Usuario Usuario { get; private set; }

        public CriarUsuarioEvent(Usuario usuario) : base(usuario.Id)
        {
        }
    }
}
