using LivrosAnimados.Core.DomainObjects;
using LivrosAnimados.Identidade.Domain.Enums;
using System;

namespace LivrosAnimados.Identidade.Domain.Models
{
    public class Usuario : Entity, IAggregateRoot
    {
        public Usuario(string nome, DateTime dataNascimento, string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Moedas = default;
            Plano = new Plano(ETipoPlano.Free, 20m);
            PlanoId = Plano.Id;
            DataCadastro = DateTime.Now;
            Email = email;

            Validar();
        }

        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public decimal Moedas { get; protected set; }
        public Guid PlanoId { get; protected set; }
        public bool Ativo { get; protected set; }

        public Plano Plano { get; protected set; }

        private void Validar()
        {
            // TODO: Validar se e-mail é válido

            if (string.IsNullOrEmpty(Nome))
                throw new DomainException("Nome do usuário não pode estar vazio");

            if (DataNascimento == null || DataNascimento == default)
                throw new DomainException("Data de nascimento do usuário não pode estar vazia");
        }

        public void AlterarPlano(Plano plano)
        {
            Plano = plano;
            PlanoId = plano.Id;
        }
    }
}
