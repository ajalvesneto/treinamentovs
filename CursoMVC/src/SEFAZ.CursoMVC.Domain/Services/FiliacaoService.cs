using SEFAZ.CursoMVC.Domain.Entities;
using SEFAZ.CursoMVC.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace SEFAZ.CursoMVC.Domain.Services
{
    public class FiliacaoService : IFiliacaoService
    {
        private readonly IFiliacaoRepository _filiacaoRepository;

        public FiliacaoService(IFiliacaoRepository filiacaoRepository) {
            _filiacaoRepository = filiacaoRepository;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            return _filiacaoRepository.Adicionar(cliente);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            return _filiacaoRepository.Atualizar(cliente);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _filiacaoRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorId(Guid guid)
        {
            return _filiacaoRepository.ObterporId(guid);
        }

        public Cliente ObterPorNome(string nome)
        {
            return _filiacaoRepository.ObterPorNome(nome);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _filiacaoRepository.ObterTodos();
        }
        public void Remover(Guid id)
        {
             _filiacaoRepository.Remover(id);
        }

        public void Dispose()
        {
            _filiacaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
