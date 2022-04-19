using LivrosAnimados.Core.Data;
using LivrosAnimados.Identidade.Domain.Models;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> ObterPorId(Guid id);

        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);

        void Adicionar(Plano plano);
        void Atualizar(Plano plano);
    }
}
