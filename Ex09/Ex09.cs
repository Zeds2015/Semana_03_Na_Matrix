using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Faça um algoritmo que leia vários números inteiros e calcule o somatório dos números negativos.
/// O fim da leitura será indicado pelo número 0.
/// </summary>

namespace Ex09
{
    public class Soma_Negativos
    {
        public int Calcular_Negativos(int n)
        {
            int soma = 0;

            while(n < 0)
            {
                soma += n;
                n++;
            }

            while (n > 0)
            {
                n--;
            }
            
                return soma;

        }

    }
}
