using System;

namespace LivrosAnimados.Identidade.API.Controllers.InputModels
{
    public class UsuarioInputModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}
