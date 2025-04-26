using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Cobrancas.Command
{
    public sealed class RemoverCobrancaCommand(int id) : IRequest<Result<bool>>
    {
        public int Id { get; set; } = id;
    }
}
