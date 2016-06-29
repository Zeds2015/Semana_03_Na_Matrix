using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno.
/// Considerar que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente.
/// </summary>

namespace Ex04
{
    public class Calcular_Media
    {
        public double Calcular(double n1,double n2,double n3)
        {
            var Media = (n1*2 + n2*3 + n3*5) / (2+3+5);
            return Media;
        }
    }
}
