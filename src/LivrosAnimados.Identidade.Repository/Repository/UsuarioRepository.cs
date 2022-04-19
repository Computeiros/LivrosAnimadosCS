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

        public async Task<Usuario> ObterPorId(Guid id)
        {
            return await _identidadeContext.Usuario.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Adicionar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Plano plano)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Plano plano)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _identidadeContext?.Dispose();
        }
    }
}
