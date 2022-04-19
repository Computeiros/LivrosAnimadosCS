using System;

namespace LivrosAnimados.Identidade.API.Controllers.ViewModels
{
    public class UsuarioViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Moedas { get; set; }
        public PlanoViewModel Plano { get; set; }
    }
}
