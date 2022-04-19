using LivrosAnimados.Core.DomainObjects;
using System;

namespace LivrosAnimados.Identidade.Domain.Models
{
    public class Usuario : Entity, IAggregateRoot
    {
        public Usuario(string nome, DateTime dataNascimento, decimal moedas, Plano plano)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Moedas = moedas;
            PlanoId = plano.Id;
            Plano = plano;
            DataCadastro = DateTime.Now;

            Validar();
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public decimal Moedas { get; private set; }
        public Guid PlanoId { get; private set; }
        public bool Ativo { get; private set; }

        public Plano Plano { get; private set; }

        private void Validar()
        {
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
