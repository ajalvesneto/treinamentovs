using AutoMapper;
using SEFAZ.CursoMVC.Application.ViewModels;
using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {

            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.Cpf,
                            opt => opt.MapFrom(src => src.Cpf))
                .ForMember(dest => dest.Email,
                            opt => opt.MapFrom(src => src.Email));


            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();


        }
    }
}
