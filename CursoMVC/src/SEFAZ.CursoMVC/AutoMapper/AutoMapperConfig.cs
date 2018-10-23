﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Application.AutoMapper
{
    class AutoMapperConfig
    {

        public static void RegisterMapping() {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            }

            );
        }
    }
}
