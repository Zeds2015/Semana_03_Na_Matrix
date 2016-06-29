using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Escreva um algoritmo que leia 50 valores e encontre o maior e o menor deles. Mostre o resultado
/// </summary>


namespace Ex08
{
    public class Vetor_50_Elementos
    {
        public int Calcular_Menor_dos_50(params int[] vetor)
        {
            int resultado = vetor.Min();
            return resultado;
        }

        public int Calcular_Maior_dos_50(params int[] vetor2)
        {
            int resultado = vetor2.Max();
            return resultado;
        }
    }
}
