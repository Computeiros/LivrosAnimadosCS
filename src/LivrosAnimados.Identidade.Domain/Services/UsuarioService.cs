using LivrosAnimados.Identidade.Domain.Interfaces;
using LivrosAnimados.Identidade.Domain.Models;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<bool> AlterarPlano(Guid usuarioId, Plano plano)
        {
            var usuario = await _usuarioRepository.ObterPorId(usuarioId);

            if (usuario is null)
                return false;

            usuario.AlterarPlano(plano);

            _usuarioRepository.Atualizar(usuario);

            return await _usuarioRepository.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            _usuarioRepository?.Dispose();
        }
    }
}
