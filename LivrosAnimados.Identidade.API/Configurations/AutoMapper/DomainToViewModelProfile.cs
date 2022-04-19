using AutoMapper;
using LivrosAnimados.Identidade.API.Controllers.ViewModels;
using LivrosAnimados.Identidade.Domain.Models;

namespace LivrosAnimados.Identidade.API.Configurations.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>()
                .ForMember(u => u.Nome, opt => opt.MapFrom(u => u.Nome))
                .ForMember(u => u.Email, opt => opt.MapFrom(u => u.Email))
                .ForMember(u => u.DataNascimento, opt => opt.MapFrom(u => u.DataNascimento))
                .ForMember(u => u.DataCadastro, opt => opt.MapFrom(u => u.DataCadastro))
                .ForMember(u => u.Moedas, opt => opt.MapFrom(u => u.Moedas))
                .ForMember(u => u.Plano, opt => opt.MapFrom(u => u.Plano));

            CreateMap<Plano, PlanoViewModel>()
                .ForMember(p => p.Tipo, opt => opt.MapFrom(p => nameof(p.Tipo)))
                .ForMember(p => p.DataAssinatura, opt => opt.MapFrom(p => p.DataAssinatura))
                .ForMember(p => p.DataProximoVencimento, opt => opt.MapFrom(p => p.DataProximoVencimento))
                .ForMember(p => p.Valor, opt => opt.MapFrom(p => p.Valor))
                .ForMember(p => p.Ativo, opt => opt.MapFrom(p => p.Ativo));
        }
    }
}
