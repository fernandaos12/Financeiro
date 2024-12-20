using Financeiro.Api.Enums;

namespace Financeiro.Api.Services;

public abstract class DescontosService
{
    public abstract decimal CalcularDesconto(decimal valor);
}


public class DescontosCompras : DescontosService
{
    public override decimal CalcularDesconto(decimal valor)
    {
        return valor * 0.05M;
    }
}

public class DescontosCashback : DescontosService
{
    public override decimal CalcularDesconto(decimal valor) 
    {
        return valor * 0.05M;
    }
}