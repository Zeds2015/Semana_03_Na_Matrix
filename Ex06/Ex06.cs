using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{/// <summary>
    /// Calcule a média aritmética das 3 notas de um aluno e mostre, 
    /// além do valor da média, uma mensagem de "Aprovado", caso a média 
    /// seja igual ou superior a 6, ou a mensagem "reprovado", caso contrário.
    /// </summary>
    

    public class Aprovado_Reprovado
    {
        public string Calcula_e_Aprova_ou_Nao(double media)
        {
            string resultado;

            if(media >= 6)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }
            return resultado;
        }
    }
}
