using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex08;

/// <summary>
///  Escreva um algoritmo que leia 50 valores e encontre o maior e o menor deles. Mostre o resultado
/// </summary>

namespace Ex08Teste
{
    [TestClass]
    public class Ex08Teste
    {
        [TestMethod]
        public void Vetor_Menor_e_Maior_Numero()
        {
            var vetor_50 = new int[50];
            int cont = 1;
            
            for(int i = 0; i < 50; i++,cont++)
            {
                vetor_50[i] = cont;
            }

            Vetor_50_Elementos calcular_Vetor = new Vetor_50_Elementos();
            var menor = calcular_Vetor.Calcular_Menor_dos_50(vetor_50);
            var maior = calcular_Vetor.Calcular_Maior_dos_50(vetor_50);

            Assert.AreEqual(1, menor);
            Assert.AreEqual(50, maior);
        }
    }
}
