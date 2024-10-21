using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;

namespace Financeiro.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    //teste iterando varias vezes

    [TestMethod]
    [DataRow(1,2,3)]
    [DataRow(5,10,15)]
    [DataRow(-3,3,0)]
    public void SomaDoisNumeros_ComDataRow(int valor1, int valor2, int valor3){
        var resultado = Calculadora.Somar(valor1,valor2);
        Assert.AreEqual(esperado, resultado);
    }  
    
    [TestMethod]
    [DataRow("teste@email.com", true)]
    [DataRow("emailerrado@email.com", false)]
    [DataRow("emailvalido@dominio.com", true)]
    public void ValidarEmail_ComDataRow(string email, bool esperado){
        var resultado = EmailValidar(email);
        Assert.AreEqual(esperado, resultado);
    }

}