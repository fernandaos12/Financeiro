
using Financeiro.Teste.Interfaces;
using Financeiro.Teste.Models;

namespace Financeiro.Teste.Entities
{
    public class ContasPagarTesteRepository : IContasPagarRepositoryTeste
    {
        private readonly IContasPagarRepositoryTeste _objetorepositorio;
        private ContasPagarTesteModel _modelCPTeste;
        private int _count;
        private bool _result;

        public ContasPagarTesteRepository(IContasPagarRepositoryTeste repositoriocontaspagar)
        {
            _objetorepositorio = repositoriocontaspagar ?? throw new ArgumentNullException(nameof(repositoriocontaspagar));
        }

        public ContasPagarTesteRepository()
        {
        }

        public Task<bool> AtualizarContaPagar(ContasPagarTesteModel contaspagar)
        {
            return Task.FromResult(true);
        }

        public async Task<ContasPagarTesteModel> ObterContaPagarPorId(int id)
        {
            //  return new ContasPagarTesteModel();

            var retorno = new ContasPagarTesteModel();
            retorno.Id = id;
            return retorno;
        }

        public async Task<bool> RemoverContaPagar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SalvarContaPagar(ContasPagarTesteModel contaspagar)
        {
            _count++;
            _modelCPTeste = contaspagar;
            return _result;

        }

        public void SetResult(bool result)
        {
            _result = result;

        }
        public ContasPagarTesteModel RetornoSalvarObjetoCpTeste() => _modelCPTeste;

        public int RetornaQdadeEnvioRequisicao() => _count;

        public async Task<bool> AdicionarContaPagar(ContasPagarTesteModel model)
        {
            var existeItem = await ObterContaPagarPorId(model.Id);
            //if (existeItem != null) return false;

            var conta = new ContasPagarTesteModel();
            conta.Descricao = model.Descricao;
            conta.Valor = model.Valor;

            var sucesso = await _objetorepositorio.AdicionarContaPagar(conta);
            return sucesso;
        }

        //internal async Task<bool> AdicionarContaPagar(ContasPagar model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
