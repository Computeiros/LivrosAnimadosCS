using LivrosAnimados.Identidade.Domain.Models;
using System;

namespace LivrosAnimados.Identidade.Test.Builder
{
    public class UsuarioBuilder : Usuario
    {
        public UsuarioBuilder(
            string nome = default,
            DateTime dataNascimento = default,
            string email = default) : base(nome, dataNascimento, email)
        {
        }

        public UsuarioBuilder Valido()
        {
            Nome = "Usuario Builder";
            DataNascimento = DateTime.Parse("2000/10/02");
            Moedas = 20.00m;
            Plano = new PlanoBuilder().Valido().Build();
            Email = "usuario.builder@email.com";

            return this;
        }
    }
}
