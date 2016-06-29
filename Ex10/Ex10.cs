using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Escrever um algoritmo que leia 20 valores para uma variável n e, para cada um deles, calcule a tabuada de 1 até n. Mostre a tabuada na forma:
///1 x n = n
///2 x n = 2n
///3 x n = 3n
///.......
///n x n = n²
/// </summary>

namespace Ex10
{
    public class tabuada_ate_N
    {
        public int Calcular_Tabuada(int x, int v)
        {
            int result = x;
            result += 1;
            var tabuada = new int[result];

            for(int i  = 0; i < result; i++)
            {
                tabuada[i] = x * i;
            }
            return tabuada[v];
        }
    }
}
