using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex02;

namespace Ex02Teste
{
    /// <summary>
    /// Dados três valores distintos, colocá-los em ordem crescente.
    /// </summary>

    [TestClass]
    public class Ex02Test
    {
        Ordenar_Vetor Ordena_vetor = new Ordenar_Vetor();

        [TestMethod]
        public void Ordenar()
        {
            int num1, num2, num3;

            num1 = 1;
            num2 = 2;
            num3 = 3;

            var ordem = Ordena_vetor.Calcular_e_Ordenar(num1, num2, num3);

            Assert.AreEqual(1, ordem[0]);
            Assert.AreEqual(2, ordem[1]);
            Assert.AreEqual(3, ordem[2]);
        }

        [TestMethod]
        public void Ordenar_Vetor2()
        {
            int num1, num2, num3;

            num1 = 2;
            num2 = 1;
            num3 = 3;

            var ordem = Ordena_vetor.Calcular_e_Ordenar(num1, num2, num3);

            Assert.AreEqual(1, ordem[0]);
            Assert.AreEqual(2, ordem[1]);
            Assert.AreEqual(3, ordem[2]);
        }

        [TestMethod]
        public void Ordenar_Vetor3()
        {
            int num1, num2, num3;

            num1 = 3;
            num2 = 2;
            num3 = 1;

            var ordem = Ordena_vetor.Calcular_e_Ordenar(num1, num2, num3);

            Assert.AreEqual(1, ordem[0]);
            Assert.AreEqual(2, ordem[1]);
            Assert.AreEqual(3, ordem[2]);
        }
    }
}
