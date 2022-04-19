using LivrosAnimados.Core.Messages.CommonMessages.DomainEvents;
using LivrosAnimados.Identidade.Domain.Models;

namespace LivrosAnimados.Identidade.Domain.Events
{
    public class CriarUsuarioEvent : DomainEvent
    {
        public Usuario Usuario { get; protected set; }

        public CriarUsuarioEvent(Usuario usuario) : base(usuario.Id)
        {
            Usuario = usuario;
        }
    }
}
