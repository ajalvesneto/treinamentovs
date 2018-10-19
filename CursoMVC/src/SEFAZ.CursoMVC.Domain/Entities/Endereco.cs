using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Domain.Entities
{
    public class Endereco
    {
        public Endereco() {
            EnderecoId = Guid.NewGuid();
        }

        public Guid EnderecoId { get; set; }
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public Guid CLienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        
    }
}
