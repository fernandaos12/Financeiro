namespace Financeiro.Domain.Abstractions
{
    public interface ISpecifications<T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
