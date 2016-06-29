using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex06;

/// <summary>
/// Calcule a média aritmética das 3 notas de um aluno e mostre, 
/// além do valor da média, uma mensagem de "Aprovado", caso a média 
/// seja igual ou superior a 6, ou a mensagem "reprovado", caso contrário.
/// </summary>

namespace Ex06Teste
{
    [TestClass]
    public class Ex06Teste
    {
        Aprovado_Reprovado verificar_media = new Aprovado_Reprovado();

        [TestMethod]
        public void Calcula_e_Aprova()
        {
            double nota1 = 8.8;
            double nota2 = 8.0;
            double nota3 = 4.6;

            double media = (nota1 + nota2 + nota3) / 3;
            var situacao = verificar_media.Calcula_e_Aprova_ou_Nao(media);

            Assert.AreEqual("Aprovado", situacao);
        }

        [TestMethod]
        public void Calcula_e_Reprova()
        {
            double nota1 = 4.0;
            double nota2 = 4.0;
            double nota3 = 4.0;

            double media = (nota1 + nota2 + nota3) / 3;
            var situacao = verificar_media.Calcula_e_Aprova_ou_Nao(media);

            Assert.AreEqual("Reprovado", situacao);
        }
    }
}
