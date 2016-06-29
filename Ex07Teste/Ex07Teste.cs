using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex07;

namespace Ex07Teste
{
    [TestClass]
    public class Ex07Teste
    {
        /// <summary>
        /// 
        /// Elabore um algoritmo que dada a idade de um nadador
        /// classifica-o em uma das seguintes categorias:
        ///infantil A = 5 - 7 anos
        ///infantil B = 8-10 anos
        ///juvenil A = 11-13 anos
        ///juvenil B = 14-17 anos
        ///adulto = maiores de 18 anos
        /// </summary>

        Nadar calcular_Idade = new Nadar();

        [TestMethod]
        public void Bebes_menores_que_7()
        {
            int idade = 7;

            var cat = calcular_Idade.Calcular_Idade_Nadador(idade);

            Assert.AreEqual("Infantil A", cat);
        }

        [TestMethod]
        public void Idade_maior_que_7()
        {
            int idade = 10;

            var cat = calcular_Idade.Calcular_Idade_Nadador(idade);

            Assert.AreEqual("Infantil B", cat);
        }

        [TestMethod]
        public void Idade_maior_que_10()
        {
            int idade = 13;

            var cat = calcular_Idade.Calcular_Idade_Nadador(idade);

            Assert.AreEqual("Juvenil A", cat);
        }

        [TestMethod]
        public void idade_Maior_que_13()
        {
            int idade = 17;

            var cat = calcular_Idade.Calcular_Idade_Nadador(idade);

            Assert.AreEqual("Juvenil B", cat);
        }

        [TestMethod]
        public void Adultos()
        {
            int idade = 18;

            var cat = calcular_Idade.Calcular_Idade_Nadador(idade);

            Assert.AreEqual("Adultos", cat);
        }
    }
}
