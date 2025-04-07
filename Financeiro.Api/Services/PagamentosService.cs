using AutoMapper;
using Financeiro.Api.Models;
using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository;
using Financeiro.Api.Services.Interfaces;

namespace Financeiro.Api.Services
{
    public class PagamentosService : IPagamentoDTO
    {
        private readonly IMapper _map;
        private readonly PagamentosRepository _repo;

        public PagamentosService(IMapper map, PagamentosRepository repo)
        {
            _repo = repo ?? throw new ArgumentNullException("Erro ao conectar ao banco de dados");
            _map = map;
        }
        public async Task<PagamentoDTO> Atualizar(PagamentoDTO pgto)
        {
            var obj = _map.Map<Pagamento>(pgto);
            await _repo.Atualizar(obj);
            return pgto;
        }

        public async Task<PagamentoDTO> BuscarPorId(int id)
        {
            var item = await _repo.FindId(id);
            if (item == null)
            {
                throw new ArgumentException("Pagamento não encontrado");
            }
            return _map.Map<PagamentoDTO>(item);
        }

        public async Task<PagamentoDTO> Cadastrar(PagamentoDTO pgto)
        {
            var obj = _map.Map<Pagamento>(pgto);
            await _repo.Salvar(obj);
            return pgto;
        }

        public async Task<bool> Excluir(int id)
        {
            var item = _repo.FindId(id);
            if (item == null)
            {
                throw new ArgumentException("Pagamento nao encontrado");
            }
            await _repo.Remover(id);
            return true;
        }

        public Task<List<PagamentoDTO>> Listar()
        {
            var listaPgto = _repo.Listar();
            return _map.Map<Task<List<PagamentoDTO>>>(listaPgto);
        }
    }
}
