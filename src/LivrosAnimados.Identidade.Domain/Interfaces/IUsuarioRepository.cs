using LivrosAnimados.Core.Data;
using LivrosAnimados.Identidade.Domain.Models;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> ObterPorId(Guid id);
    }
}
