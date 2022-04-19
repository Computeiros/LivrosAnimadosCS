using LivrosAnimados.Identidade.Domain.Enums;
using LivrosAnimados.Identidade.Domain.Models;
using System;

namespace LivrosAnimados.Identidade.Test.Builder
{
    public class PlanoBuilder : Plano
    {
        public PlanoBuilder(
            ETipoPlano tipo = default,
            decimal valor = default) : base(tipo, valor)
        {
        }

        public PlanoBuilder Valido()
        {
            Tipo = ETipoPlano.Free;
            Valor = 25.00m;

            return this;
        }

        public PlanoBuilder ComValor(decimal valor)
        {
            Valor = valor;

            return this;
        }

        public Plano Build() => this;
    }
}
