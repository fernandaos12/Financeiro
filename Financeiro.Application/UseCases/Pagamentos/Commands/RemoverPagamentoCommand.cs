using Financeiro.Application.UseCases.Response;
using MediatR;

namespace Financeiro.Application.UseCases.Pagamentos.Commands
{
    public sealed class RemoverPagamentoCommand(int id) : IRequest<Result<bool>>
    {
        public int Id { get; set; } = id;
    }
}
