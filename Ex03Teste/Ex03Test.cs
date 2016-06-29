using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex03;

/// <summary>
/// Escreva um algoritmo que leia três números inteiros e positivos (A, B, C) 
/// e calcule a seguinte expressão: D = R + S / 2
///onde:
///R = (A + B)²
///S = (B + C)²
/// </summary>


namespace Ex03Teste
{
    [TestClass]
    public class Ex03Test
    {
        [TestMethod]
        public void Calcular_o_Valor_de_D()
        {
            int A, B, C;

            A = 7;
            B = 7;
            C = 7;

            Calcula_D calcular_Valor_de_D = new Calcula_D();
            var resultado = calcular_Valor_de_D.Calcular(A, B, C);

            Assert.AreEqual(294, resultado);
        }
    }
}
