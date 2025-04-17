using Financeiro.Domain.Abstractions;
using MediatR;

namespace Financeiro.Application.UseCases.ContasPagar.GetById
{
    //saida
    public sealed record Response(int Id, string Descricao) : IRequest<Result<Response>>
    {
        //dado um command ele sabe quem é o handler manipulador - mediatr



    }
}
