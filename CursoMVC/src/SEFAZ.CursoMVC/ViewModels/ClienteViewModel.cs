using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
            Enderecos = new List<EnderecoViewModel>();
        }

        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [MaxLength(11,ErrorMessage ="Campo Obrigatório")]
        public string Cpf { get; set; }

        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage ="E-email inválido")]
        public string Email { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
        public DateTime DataNascimento { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data Inválida")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<EnderecoViewModel> Enderecos { get; set; }
    }
}
