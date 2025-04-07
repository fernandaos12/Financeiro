using Financeiro.Business.Commands.Interface;

namespace Financeiro.Business.Commands
{
    internal class Receiver : IReceiver<Command>
    {
        public void Handle(Command command)
        {
            command.Executar();
        }
    }
}
