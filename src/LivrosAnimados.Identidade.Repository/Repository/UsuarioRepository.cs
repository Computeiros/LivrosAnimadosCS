using LivrosAnimados.Core.Data;
using LivrosAnimados.Identidade.Domain.Interfaces;
using LivrosAnimados.Identidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IdentidadeContext _identidadeContext;

        public UsuarioRepository(IdentidadeContext identidadeContext)
        {
            _identidadeContext = identidadeContext;
        }

        public IUnitOfWork UnitOfWork => _identidadeContext;

        public void Dispose()
        {
            _identidadeContext?.Dispose();
        }

        public async Task<Usuario> ObterPorId(Guid id)
        {
            return await _identidadeContext.Usuario.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
