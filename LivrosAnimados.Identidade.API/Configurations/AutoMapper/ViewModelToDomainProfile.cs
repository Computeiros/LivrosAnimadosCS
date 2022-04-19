using AutoMapper;
using LivrosAnimados.Identidade.API.Controllers.InputModels;
using LivrosAnimados.Identidade.Domain.Models;

namespace LivrosAnimados.Identidade.API.Configurations.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<UsuarioInputModel, Usuario>()
                .ConstructUsing(u => new Usuario(u.Nome, u.DataNascimento, u.Email));
        }
    }
}
