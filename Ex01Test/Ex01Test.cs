using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex01;

/// <summary>
/// Fazer um programa que leia três valores numéricos, determine e imprima o menor deles.
/// </summary>

namespace Ex01Test
{
    [TestClass]
    public class Ex01Test
    {
        [TestMethod]
        public void Testar_o_Menor_Numero()
        {
            var num = new int[3];
            int cont = 1;

            for(int i = 0; i < 3; i++,cont++)
            {
                num[i] = cont;
            }
            Ex01.Ex01 calcular_Menor_Numero = new Ex01.Ex01();
            var retorno = calcular_Menor_Numero.Calcular(num);

            Assert.AreEqual(1, retorno);
        }

        [TestMethod]
        public void Testar_o_Menor_Numero2()
        {
            var num = new int[3];
            int cont = 3;

            for (int i = 0; i < 3; i++, cont--)
            {
                num[i] = cont;
            }
            Ex01.Ex01 calcular_Menor_Numero = new Ex01.Ex01();
            var retorno = calcular_Menor_Numero.Calcular(num);

            Assert.AreEqual(1, retorno);
        }

        [TestMethod]
        public void Testar_o_Menor_Numero3()
        {
            var num = new int[3];
            int cont = 3;

            for (int i = 0; i < 3; i++, cont--)
            {
                num[i] = cont;
                if(i == 2)
                {
                    cont = 1;
                    num[i] = cont;
                    cont++;
                }
            }
            Ex01.Ex01 calcular_Menor_Numero = new Ex01.Ex01();
            var retorno = calcular_Menor_Numero.Calcular(num);

            Assert.AreEqual(1, retorno);
        }
    }
}
