using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {
        private readonly ICartaoCreditoRepository _repository;
        public CartaoCreditoController(ICartaoCreditoRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<CartaoCreditoDTO>>>> ListarContas()
        {
            var itens = await _repository.Listar();
            return Ok(itens);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<CartaoCreditoDTO>>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(CartaoCreditoDTO CartaoCredito)
        {
            return Ok(await _repository.Salvar(CartaoCredito));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(CartaoCreditoDTO CartaoCredito)
        {
            var contaReceberAtualizar = await _repository.Atualizar(CartaoCredito);
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
