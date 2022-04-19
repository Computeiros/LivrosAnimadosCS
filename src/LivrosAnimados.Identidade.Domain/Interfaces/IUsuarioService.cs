using LivrosAnimados.Identidade.Domain.Models;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Interfaces
{
    public interface IUsuarioService : IDisposable
    {
        Task<bool> AlterarPlano(Guid usuarioId, Plano plano);
    }
}
