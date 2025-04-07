using AutoMapper;
using Financeiro.Api.Models;
using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository;
using Financeiro.Api.Services.Interfaces;

namespace Financeiro.Api.Services;

public class ContasPagarService : IContasPagarDTO
{
    private readonly IMapper _map;
    private readonly ContasPagarRepository _repo;

    public ContasPagarService(IMapper map, ContasPagarRepository repo)
    {
        _map = map;
        _repo = repo;
    }

    public async Task<ContasPagarDTO> Atualizar(ContasPagarDTO contasPagar)
    {
        var contas = _map.Map<ContasPagar>(contasPagar);
        await _repo.Atualizar(contas);
        return contasPagar;
    }

    public async Task<ContasPagarDTO> BuscarPorId(int id)
    {
        var conta = await _repo.FindId(id) ?? throw new ArgumentException("Conta não encontrada na base de dados.");
        return _map.Map<ContasPagarDTO>(conta);
    }

    public async Task<ContasPagarDTO> Cadastrar(ContasPagarDTO contasPagar)
    {
        var contas = _map.Map<ContasPagar>(contasPagar);
        await _repo.Salvar(contas);
        return contasPagar;
    }

    public async Task<bool> Excluir(int id)
    {
        var conta = await _repo.FindId(id) ?? throw new ArgumentException("Conta não encontrada");
        await _repo.Remover(id);
        return true;
    }

    public async Task<List<ContasPagarDTO>> Listar()
    {
        var contas = await _repo.ListarContas();
        return _map.Map<List<ContasPagarDTO>>(contas);
    }
}

