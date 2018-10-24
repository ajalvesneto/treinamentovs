using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Domain.Services
{
    public interface IFiliacaoService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);

        Cliente ObterPorId(Guid guid);

        IEnumerable<Cliente> ObterTodos();

        Cliente ObterPorCPF(string cpf);

        Cliente ObterPorNome(string nome);

        Cliente Atualizar(Cliente cliente);

        void Remover(Guid id);
    }
}
