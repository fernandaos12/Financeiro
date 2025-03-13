using Bogus;
using Financeiro.Api.Models.Enums;

namespace Financeiro.Teste.Models
{
    public class ContasPagarFake
    {
        public static ContasPagarTesteModel FakeContasPagar()
        {
            var faker = new Faker<ContasPagarTesteModel>();
            faker.RuleFor(x => x.Id, f => f.Random.Int(2));
            faker.RuleFor(x => x.Descricao, f => f.Random.String(10));
            faker.RuleFor(x => x.Valor, f => f.Random.Double(4));
            faker.RuleFor(x => x.Data_Vencimento, DateTime.Now);
            faker.RuleFor(x => x.Status_Conta, f => f.Random.Enum<StatusConta>());
            faker.RuleFor(x => x.ValorParcela, f => f.Random.Int(4));
            faker.RuleFor(x => x.Periodicidade, f => f.Random.Int(1));
            faker.RuleFor(x => x.Observacoes, f => f.Random.String(10));
            faker.RuleFor(x => x.NumeroParcelas, f => f.Random.Int(2));
            faker.RuleFor(x => x.CaminhoAnexos, f => f.Random.String(10));

            return faker;

        }

    }
}
