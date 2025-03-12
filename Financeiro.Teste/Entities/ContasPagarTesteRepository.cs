using Financeiro.Api.Models;
using Financeiro.Teste.Interfaces;
using Financeiro.Teste.Models;

namespace Financeiro.Teste.Entities
{
    public class ContasPagarTesteRepository : IContasPagarRepositoryTeste
    {
        private ContasPagarTesteModel _modelCPTeste;
        private int _count;
        private bool _result;

        public Task<bool> AtualizarContaPagar(ContasPagarTesteModel contaspagar)
        {
            return Task.FromResult(true);
        }

        public Task<ContasPagar> ObterContaPagarPorId(int id)
        {
            throw new NotImplementedException();
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
    }
}
