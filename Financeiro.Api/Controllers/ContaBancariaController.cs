using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaBancariaController : ControllerBase
    {
        private readonly IContaBancariaRepository _repository;
        public ContaBancariaController(IContaBancariaRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContaBancariaDTO>>>> ListarContas()
        {
            var lista = await _repository.Listar();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContaBancariaDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContaBancariaDTO contaBancaria)
        {
            try
            {
                var itens = new ContaBancaria
                {

                };
                await _repository.Salvar(itens);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContaBancaria contaBancaria)
        {
            var itens = new ContaBancaria
            {

            };
            await _repository.Atualizar(itens);
            return Ok(true);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }
    }
}
