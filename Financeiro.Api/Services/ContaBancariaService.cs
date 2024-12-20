namespace Financeiro.Api.Services;

public abstract class ContaBancariaService
{
    public decimal Balance { get; private set; }
    public abstract void Saque(decimal valor);
    
}

public class CheckingAccount : ContaBancariaService
{
    public override void Saque(decimal valor)
    {
        throw new NotImplementedException();
    }
}

public class Saldo : ContaBancariaService
{
    public override void Saque(decimal valor)
    {
        throw new NotImplementedException();
    }
}