using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex05;

namespace Ex05Teste
{
    /// <summary>
    /// Faça um algoritmo que leia o tempo de duração de 
    /// um evento em uma fábrica expressa em segundos e 
    /// mostre-o expresso em 
    /// horas, minutos e segundos.
    /// </summary>

    [TestClass]
    public class Ex05Teste
    {
        [TestMethod]
        public void Segundos()
        {
            int segundos = 9110;

            Horario calcula_Horario = new Horario();
            var hora = calcula_Horario.Calcular_Hora(segundos);
            var minuto = calcula_Horario.Calcular_Minutos();
            var segundo = calcula_Horario.Calcular_Segundos();

            Assert.AreEqual(2, hora);
            Assert.AreEqual(31, minuto);
            Assert.AreEqual(50, segundo);
        }
    }
}
