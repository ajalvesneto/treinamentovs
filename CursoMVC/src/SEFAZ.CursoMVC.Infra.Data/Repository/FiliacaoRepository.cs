using SEFAZ.CursoMVC.Domain.Entities;
using SEFAZ.CursoMVC.Domain.Interfaces.Repository;
using SEFAZ.CursoMVC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.Repository
{
    public class FiliacaoRepository : Repository<Cliente>, IFiliacaoRepository
    {
        public FiliacaoRepository(CursoMVCContext context) : base(context)
        {
            
        }

        public IEnumerable<Cliente> ObterAtivos()
        {
            return Buscar(c => c.Ativo);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.Cpf == cpf).FirstOrDefault();
        }

        public Cliente ObterPorNome(string nome)
        {
            return Buscar(c => c.Nome == nome).FirstOrDefault();
        }
    }
}
