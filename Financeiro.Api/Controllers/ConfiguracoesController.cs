using Financeiro.Api.Models;
using Financeiro.Api.Repository.Interfaces;
using Financeiro.Api.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers
{
    public class ConfiguracoesController : ControllerBase 
    {
        private readonly IConfiguracoes _repository;
        public ConfiguracoesController(IConfiguracoes repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<Configuracoes>>>> ListarContas()
        {
            return await _repository.Listar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Configuracoes>> FindbyId(int id)
        {
            ServiceResponse<Configuracoes> contaReceberItem = await _repository.FindId(id);
            return Ok(contaReceberItem);
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar(Configuracoes Configuracoes)
        {
            return Ok(await _repository.Salvar(Configuracoes));
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(Configuracoes Configuracoes)
        {
            ServiceResponse<Boolean> contaReceberAtualizar = await _repository.Atualizar(Configuracoes);
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