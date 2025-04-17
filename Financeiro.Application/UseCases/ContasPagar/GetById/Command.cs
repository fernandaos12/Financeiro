using Financeiro.Domain.Abstractions;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.GetById
{
    //entrada
    public sealed record Command(int Id) : IRequest<Result<Response>>;

}
