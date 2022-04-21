using AutoMapper;
using LivrosAnimados.Core.Communication.Mediator;
using LivrosAnimados.Identidade.API.Controllers.InputModels;
using LivrosAnimados.Identidade.Domain.Events;
using LivrosAnimados.Identidade.Domain.Interfaces;
using LivrosAnimados.Identidade.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Identidade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper, IMediatorHandler mediator)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        /// <summary>
        /// Obtem as informações do usuário pelo usuarioId
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <returns></returns>
        [HttpGet("{usuarioId}")]
        public async Task<ActionResult> ObterUsuario(Guid usuarioId)
        {
            var usuario = await _usuarioRepository.ObterPorId(usuarioId);

            if (usuario is null)
                return BadRequest("Usuário não encontrado");

            return Ok(usuario);
        }

        /// <summary>
        /// Criar usuário
        /// </summary>
        /// <param name="usuarioInputModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CriarUsuario(UsuarioInputModel usuarioInputModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioInputModel);

            await _mediator.PublicarDomainEvent(new CriarUsuarioEvent(usuario));

            return Ok(true);
        }
    }
}
