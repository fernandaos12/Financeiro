using Financeiro.Application.Models.DTO;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.Responses
{
    public sealed record ObterContaPorIdQuery(int id) : IRequest<Result<ContasPagarDTO>>
    {
        public int Id { get; set; }
    }
}
