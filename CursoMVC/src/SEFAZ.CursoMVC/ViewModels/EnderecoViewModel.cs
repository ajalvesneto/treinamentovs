﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }
        [Key]
        public Guid EnderecoId { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public Guid CLienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
