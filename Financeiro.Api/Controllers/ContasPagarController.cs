using Financeiro.Api.Models.DTO;
using Financeiro.Api.Repository.Models;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Repository;
using Microsoft.AspNetCore.Mvc;


namespace Financeiro.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContasPagarController : ControllerBase
    {
        private readonly IContasPagarRepository _repo;

        public ContasPagarController(IContasPagarRepository repo)
        {
            _repo = repo;
        }

        [HttpGet()]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ContasPagarDTO>>>> ListarContas()
        {
            var lista = await _repo.ListarContas();
            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContasPagarDTO>> FindbyId(int id)
        {
            var item = await _repo.FindId(id);
            return Ok(item);
        }

        [HttpPost(), DisableRequestSizeLimit]
        public async Task<ActionResult<ServiceResponse<Boolean>>> Salvar([FromBody] ContasPagarDTO contaspagar)
        {
            var contas = new ContasPagar
            {
                Descricao = contaspagar.Descricao,
                Data_Vencimento = contaspagar.Data_Vencimento,
                DataAlteracao = DateTime.Now,
                Valor = contaspagar.Valor,
                Status = Domain.Enums.Status_Default.Ativo,
                ValorPago = contaspagar.ValorPago,
                ValorParcela = contaspagar.ValorParcela,
                Periodicidade = contaspagar.Periodicidade,
                Repeticao = (Domain.Enums.TipoRepeticao)contaspagar.Repeticao,
                Anexos = contaspagar.Anexos,
                CaminhoAnexos = contaspagar.CaminhoAnexos,
                Observacao = contaspagar.Observacao,
                NumeroParcelas = contaspagar.NumeroParcelas,
                Categoria = (Domain.Enums.TipoCategoria)contaspagar.Categoria
            };


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _repo.Salvar(contas);
            return Ok(true);
        }

        [HttpPut()]
        public async Task<ActionResult<Boolean>> AtualizarItem(ContasPagarDTO contaspagar)
        {
            var contas = new ContasPagar
            {
                Descricao = contaspagar.Descricao,
                Data_Vencimento = contaspagar.Data_Vencimento,
                DataAlteracao = DateTime.Now,
                Valor = contaspagar.Valor,
                Status = Domain.Enums.Status_Default.Ativo,
                ValorPago = contaspagar.ValorPago,
                ValorParcela = contaspagar.ValorParcela,
                Periodicidade = contaspagar.Periodicidade,
                Repeticao = (Domain.Enums.TipoRepeticao)contaspagar.Repeticao,
                Anexos = contaspagar.Anexos,
                CaminhoAnexos = contaspagar.CaminhoAnexos,
                Observacao = contaspagar.Observacao,
                NumeroParcelas = contaspagar.NumeroParcelas,
                Categoria = (Domain.Enums.TipoCategoria)contaspagar.Categoria
            };

            var contaReceberAtualizar = await _repo.Atualizar(contas);
            return Ok(true);
        }

        [HttpDelete()]
        public async Task<ActionResult<Boolean>> Apagar(int id)
        {
            var contaReceberRemover = await _repo.Remover(id);
            return Ok(true);
        }
    }
}