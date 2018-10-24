using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Domain.Interfaces.Repository
{
   public interface IFiliacaoRepository : IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorNome(string nome);
        IEnumerable<Cliente> ObterAtivos();
    }
}
