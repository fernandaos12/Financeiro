using Financeiro.Api.Repository.Models;
using Financeiro.Application.Models.DTO;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    public class ConfiguracoesController : ControllerBase
    {
        private readonly IConfiguracoesRepository _repository;
        public ConfiguracoesController(IConfiguracoesRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ConfiguracoesDTO>>>> ListarContas()
        {
            await _repository.Listar();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConfiguracoesDTO>> FindbyId(int id)
        {
            var contaReceberItem = await _repository.ObterporId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(ConfiguracoesDTO config)
        {
            var itens = new Configuracoes
            {
                Nome = config.Nome,
            };
            await _repository.Salvar(itens);
            return Ok();
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(Configuracoes configuracoes)
        {
            bool contaReceberAtualizar = await _repository.Atualizar(configuracoes);
            return Ok(contaReceberAtualizar);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            bool contaReceberRemover = await _repository.Remover(id);
            return Ok(contaReceberRemover);
        }
    }
}