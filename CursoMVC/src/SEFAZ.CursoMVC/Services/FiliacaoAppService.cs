

using System;
using System.Collections.Generic;
using AutoMapper;
using SEFAZ.CursoMVC.Application.Interfaces;
using SEFAZ.CursoMVC.Application.ViewModels;
using SEFAZ.CursoMVC.Domain.Entities;
using SEFAZ.CursoMVC.Domain.Services;
using SEFAZ.CursoMVC.Infra.Data.UnitofWork;

namespace SEFAZ.CursoMVC.Application.Services
{
    public class FiliacaoAppService : AppService, IFiliacaoAppService
    {
        private readonly IFiliacaoService _filiacaoService;


        public FiliacaoAppService(IFiliacaoService filiacaoService, IUnitofWork unitofWork) : base(unitofWork) {
            _filiacaoService = filiacaoService;
        }

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteEnderecoViewModel.ClienteViewModel);

            var endereco = Mapper.Map<Endereco>(clienteEnderecoViewModel.EnderecoViewModel);

            cliente.Enderecos.Add(endereco);

            var clienteReturn = _filiacaoService.Adicionar(cliente);

            clienteEnderecoViewModel.ClienteViewModel = Mapper.Map<ClienteViewModel>(clienteReturn);

            return clienteEnderecoViewModel;
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<Cliente>(clienteViewModel);
            var clienteReturn = _filiacaoService.Adicionar(cliente);
            return Mapper.Map<ClienteViewModel>(clienteReturn);

        }

        public void Dispose()
        {
            _filiacaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorNome(string nome)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorNome(nome));
        }

        public ClienteViewModel ObterPorId(Guid Id)
        {
            return Mapper.Map<ClienteViewModel>(_filiacaoService.ObterPorId(Id));
        }


        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<ICollection<ClienteViewModel>>(_filiacaoService.ObterTodos());
        }

        public void Remover(Guid Id)
        {
            _filiacaoService.Remover(Id);
        }
    }
}
