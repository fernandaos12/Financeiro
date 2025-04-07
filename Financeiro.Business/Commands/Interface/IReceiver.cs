namespace Financeiro.Business.Commands.Interface
{
    public interface IReceiver<T>
    {
        void Handle(T command);
    }
}
