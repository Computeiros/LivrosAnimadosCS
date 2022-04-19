using LivrosAnimados.Core.Messages.CommonMessages.DomainEvents;
using LivrosAnimados.Identidade.Domain.Models;
using System;

namespace LivrosAnimados.Identidade.Domain.Events
{
    public class AlterarPlanoUsuarioEvent : DomainEvent
    {
        public Plano Plano { get; protected set; }
        public Guid UsuarioId { get; protected set; }

        public AlterarPlanoUsuarioEvent(Plano plano, Guid usuarioId) : base(usuarioId)
        {
            Plano = plano;
            UsuarioId = usuarioId;
        }
    }
}
