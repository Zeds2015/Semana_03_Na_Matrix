using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex09;

/// <summary>
/// Faça um algoritmo que leia vários números inteiros e calcule o somatório dos números negativos.
/// O fim da leitura será indicado pelo número 0.
/// </summary>

namespace UnitTestProject1
{
    [TestClass]
    public class Ex09Teste
    {
        Soma_Negativos somar_somente_os_negativos = new Soma_Negativos();

        [TestMethod]
        public void Somar_Negativos()
        {
            int numero = -10;
            int somatorio = somar_somente_os_negativos.Calcular_Negativos(numero);
            Assert.AreEqual(-55, somatorio);
        }

        [TestMethod]
        public void Passar_Positivos()
        {
            int numero = 10;
            int somatorio = somar_somente_os_negativos.Calcular_Negativos(numero);
            Assert.AreEqual(0, somatorio);
        }
    }
}
