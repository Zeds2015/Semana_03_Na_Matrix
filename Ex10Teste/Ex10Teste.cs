using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex10;

/// <summary>
/// Escrever um algoritmo que leia 20 valores para uma variável n e, para cada um deles, calcule a tabuada de 1 até n. Mostre a tabuada na forma:
///1 x n = n
///2 x n = 2n
///3 x n = 3n
///.......
///n x n = n²
/// </summary>


namespace Ex10Teste
{
    [TestClass]
    public class Ex10Teste
    {
        tabuada_ate_N calculo_de_Tabuada = new tabuada_ate_N();

        [TestMethod]
        public void Tabuada_10()
        {
            int num = 10;
            int vezes = 10;

            var resultado = calculo_de_Tabuada.Calcular_Tabuada(num,vezes);

            Assert.AreEqual(100, resultado);
        }

        [TestMethod]
        public void Tabuada_20()
        {
            int num = 20;
            int vezes = 20;

            var resultado = calculo_de_Tabuada.Calcular_Tabuada(num,vezes);

            Assert.AreEqual(400, resultado);
        }

        [TestMethod]
        public void Tabuada_15_vezes_5()
        {
            int num = 15;
            int vezes = 5;

            var resultado = calculo_de_Tabuada.Calcular_Tabuada(num,vezes);

            Assert.AreEqual(75, resultado);
        }
    }
}
