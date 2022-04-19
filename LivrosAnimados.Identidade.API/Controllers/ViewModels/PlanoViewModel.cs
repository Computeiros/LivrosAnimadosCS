using System;

namespace LivrosAnimados.Identidade.API.Controllers.ViewModels
{
    public class PlanoViewModel
    {
        public DateTime DataAssinatura { get; set; }
        public DateTime DataProximoVencimento { get; set; }
        public string Tipo { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
    }
}
