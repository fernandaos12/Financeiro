using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitasRepository _repository;
        public ReceitasController(IReceitasRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ReceitasDTO>>>> ListarContas()
        {
            var listar = await _repository.Listar();
            return Ok(listar);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReceitasDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ReceitasDTO receitas)
        {
            try
            {
                var itens = new Receitas
                {
                    Descricao = receitas.Descricao
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
        public async Task<ActionResult<Boolean>> AtualizarItem(Receitas Receitas)
        {
            var contaReceberAtualizar = await _repository.Atualizar(Receitas);
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
