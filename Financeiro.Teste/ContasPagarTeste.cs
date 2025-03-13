
using Financeiro.Teste.Entities;
using Financeiro.Teste.Interfaces;
using Financeiro.Teste.Models;
using Moq;

namespace Financeiro.Teste
{
    public class ContasPagarTeste
    {
        private readonly Mock<IContasPagarRepositoryTeste> _contaspagarRepoMock;

        public ContasPagarTeste()
        {
            _contaspagarRepoMock = new Mock<IContasPagarRepositoryTeste>();
        }

        [Fact]
        public async Task ValidarAtualizarObjetoContasPagar()
        {
            //Arrange
            var cp = new ContasPagarTesteModel()
            {
                Descricao = "Teste Conta Pagar",
                Data_Vencimento = DateTime.Now,
                Valor = 100.0,
                //Status_Conta = StatusConta.Pendente,
                CategoriaId = 1,
                //Repeticao = TipoRepeticao.UNICO,
                Periodicidade = 1,
                ValorParcela = 100,
                NumeroParcelas = 1,
                Observacoes = "Conta a pagar de teste",
                CaminhoAnexos = "C:\\Users\\fernanda\\Desktop\\Teste.pdf",
                Anexos = new byte[] { 1, 2, 3, 4, 5 },
                PagamentoId = 1,
            };

            var repositoriocontapagar = new ContasPagarTesteRepository();

            //act
            var resultadoAtualizarObjetoNaoNulo =
                await repositoriocontapagar.AtualizarContaPagar(cp);
            //assert
            Assert.True(resultadoAtualizarObjetoNaoNulo);
        }


        [Fact]
        public async Task ValidarSalvarNovoItemContasPagar()
        {
            //Arrange
            ContasPagarTesteModel cp = new ContasPagarTesteModel()
            {
                Descricao = "Teste Conta Pagar",
                Data_Vencimento = DateTime.Now,
                Valor = 100.0,
                //Status_Conta = StatusConta.Pendente,
                CategoriaId = 1,
                //Repeticao = TipoRepeticao.UNICO,
                Periodicidade = 1,
                ValorParcela = 100,
                NumeroParcelas = 1,
                Observacoes = "Conta a pagar de teste",
                CaminhoAnexos = "C:\\Users\\fernanda\\Desktop\\Teste.pdf",
                Anexos = new byte[] { 1, 2, 3, 4, 5 },
                PagamentoId = 1,
            };
            var repositoriocontapagar = new ContasPagarTesteRepository();
            repositoriocontapagar.SetResult(true);

            //act
            var resultado = await repositoriocontapagar.SalvarContaPagar(cp);

            //assert
            Assert.True(resultado);
            Assert.Equal(cp, repositoriocontapagar.RetornoSalvarObjetoCpTeste());
            Assert.Equal(1, repositoriocontapagar.RetornaQdadeEnvioRequisicao());
        }


        [Fact]
        public async Task AdicionarItemContaPagarRetornarTrue()
        {
            int Idconta = 1;

            //Arrange
            _contaspagarRepoMock.Setup(x => x.ObterContaPagarPorId(Idconta)).ReturnsAsync(new ContasPagarTesteModel());
            _contaspagarRepoMock.Setup(x => x.AdicionarContaPagar(It.IsAny<ContasPagarTesteModel>())).ReturnsAsync(true);

            var repositorio = new ContasPagarTesteRepository(_contaspagarRepoMock.Object);
            var modelfake = ContasPagarFake.FakeContasPagar(); //envia os dados fake
            //act
            var resultado = await repositorio.AdicionarContaPagar(modelfake);

            //assert
            Assert.True(resultado);
        }


    }
}