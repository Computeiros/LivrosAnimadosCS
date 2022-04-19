using LivrosAnimados.Core.DomainObjects;
using LivrosAnimados.Identidade.Domain.Enums;
using System;

namespace LivrosAnimados.Identidade.Domain.Models
{
    public class Plano : Entity
    {
        public Plano(ETipoPlano tipo, decimal valor)
        {
            DataAssinatura = DateTime.Now;
            DataProximoVencimento = DateTime.Now.AddDays(30);
            Tipo = tipo;
            Ativo = true;
            Valor = valor;

            Validar();
        }
        
        public DateTime DataAssinatura { get; protected set; }
        public DateTime DataProximoVencimento { get; protected set; }
        public ETipoPlano Tipo { get; protected set; }
        public bool Ativo { get; protected set; }
        public decimal Valor { get; protected set; }

        private void Validar()
        {

        }
    }
}
