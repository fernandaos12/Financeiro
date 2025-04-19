namespace Financeiro.Domain.Abstractions
{
    public interface IPagamento<T>
    {
        Task<T> ProcessarPagamento(T entity);
        Task<T> CancelarPagamento(T entity);
        Task<T> ObterCodigoPagammento();
    }
}
