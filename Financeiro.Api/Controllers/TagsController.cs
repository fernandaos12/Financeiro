using Financeiro.Api.Models;
using Financeiro.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsController //: BaseController
    {
        private readonly TagsRepository _repository;
        public TagsController(TagsRepository repo)
        {
            _repository = repo;
        }

        [HttpGet()]
        public async Task<IEnumerable<Tags>> ListarContas()
        {
           var retorno = await _repository.ListarContas();

           return retorno;
        }

        [HttpGet("{id}")]
        public async Task<Tags> FindbyId(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }
            return retorno;         
        }

        [HttpPost()]
        public async Task<bool> Salvar(Tags cp)
        {
            await _repository.Salvar(cp);
            return true;         
        }

        [HttpPut("{id:int}")]
        public async void AtualizarItem(Tags cp)
        { 
            var item = await _repository.FindId(cp.Id);
            if(item == null){
                throw new Exception("Erro ao atualizar.Item não encontrado.");
            }
            
            _repository.Atualizar(cp);            
        }

        [HttpDelete("{id:int}")]
        public async Task<bool> Apagar(int id)
        {
            var retorno = await _repository.FindId(id);
            if(retorno == null){
                 throw new Exception("Conta a pagar não encontrado.");
            }

            await _repository.Remover(id);
            return true;  
        }


    }
}