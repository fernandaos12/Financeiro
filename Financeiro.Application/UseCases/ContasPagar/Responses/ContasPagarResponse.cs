namespace Financeiro.Application.UseCases.ContasPagar.Responses
{
    //public sealed record Response(bool sucesso, string Descricao) : IRequest<Result<Response>>
    //{
    //}

    public sealed record Result<T>
    {
        public Result(T dados)
        {
            Dados = dados;
        }
        public T Dados { get; set; }
    }
}
