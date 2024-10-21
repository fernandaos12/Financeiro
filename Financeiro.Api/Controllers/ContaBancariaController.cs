using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaBancariaController : ControllerBase
    {
        private readonly IContaBancaria _repository;
        public ContaBancariaController(IContaBancaria repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContaBancaria>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContaBancaria>> FindbyId(int id)
        {
            ServiceResponse<ContaBancaria> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ContaBancaria ContaBancaria)
        {
            return Ok(await _repository.Salvar(ContaBancaria));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContaBancaria ContaBancaria)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(ContaBancaria);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            ServiceResponse<Boolean> contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }
    }
}
