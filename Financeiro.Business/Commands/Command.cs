using Financeiro.Business.Commands.Interface;

namespace Financeiro.Business.Commands
{
    public class Command : ICommand
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public Command(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
        public void Executar()
        {
            Console.WriteLine("Executando comando: ");
        }
    }
}
