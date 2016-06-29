using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex04;

namespace Ex04Teste
{
    /// <summary>
    /// Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno.
    /// Considerar que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente.
    /// </summary>
    

    [TestClass]
    public class Ex04Test
    {
        [TestMethod]
        public void Calculo_Media()
        {
            double nota1, nota2, nota3;

            nota1 = 7.5;
            nota2 = 5.5;
            nota3 = 10.0;

            Calcular_Media Exercicio = new Calcular_Media();
            double Media = Exercicio.Calcular(nota1, nota2, nota3);

            Assert.AreEqual(8.15, Media);
        }
    }
}
