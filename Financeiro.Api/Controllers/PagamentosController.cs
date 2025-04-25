using Financeiro.Api.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IPagamentosRepository _repository;
        public PagamentosController(IPagamentosRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<PagamentoDTO>>>> ListarContas()
        {
            var lista = await _repository.Listar();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PagamentoDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(PagamentoDTO pagamentos)
        {
            var itens = new Pagamento
            {
                DataPagamento = pagamentos.DataPagamento,
                DataVencimento = pagamentos.DataVencimento,
                Valor = pagamentos.Valor,
                Observacao = pagamentos.Observacao,
                FormaPagamento = (Domain.Enums.FormaPagamentoEnum)pagamentos.FormaPagamento,
            };
            await _repository.Salvar(itens);
            return Ok();
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(PagamentoDTO pagamentos)
        {
            var itens = new Pagamento
            {
                DataPagamento = pagamentos.DataPagamento,
                DataVencimento = pagamentos.DataVencimento,
                Valor = pagamentos.Valor,
                Observacao = pagamentos.Observacao,
                FormaPagamento = (Domain.Enums.FormaPagamentoEnum)pagamentos.FormaPagamento,
            };
            var contaReceberAtualizar = await _repository.Atualizar(itens);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }

    }
}
