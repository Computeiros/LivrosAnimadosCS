using LivrosAnimados.Core.DomainObjects;
using LivrosAnimados.Identidade.Domain.Enums;
using System;

namespace LivrosAnimados.Identidade.Domain.Models
{
    public class Plano : Entity
    {
        public Plano(ETipoPlano tipo, decimal valor, Guid usuarioId)
        {
            DataAssinatura = DateTime.Now;
            DataProximoVencimento = DateTime.Now.AddDays(30);
            Tipo = tipo;
            Ativo = true;
            Valor = valor;
            UsuarioId = usuarioId;

            Validar();
        }

        public DateTime DataAssinatura { get; private set; }
        public DateTime DataProximoVencimento { get; private set; }
        public ETipoPlano Tipo { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public Guid UsuarioId { get; private set; }

        public Usuario Usuario { get; private set; }

        private void Validar()
        {

        }
    }
}
