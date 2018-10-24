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
    public class ViewModelToDomainMappingProfile : Profile
    {

        
            public ViewModelToDomainMappingProfile() {
               /* CreateMap<ClienteViewModel, Cliente>()
                    .ForMember(dest => dest.Email, 
                    opt => opt.ResolveUsing(
                        model => new Email() {
                            Endereco = model.Email
                            }
                        )
                    );*/

            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
            
        }

        /*private class Email
        {
            public Email()
            {
            }

            public string Endereco { get; set; }
        }*/
    }
}

