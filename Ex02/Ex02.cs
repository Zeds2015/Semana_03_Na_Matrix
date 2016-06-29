using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Dados três valores distintos, colocá-los em ordem crescente.
/// </summary>

namespace Ex02
{
    public class Ordenar_Vetor
    {
        public int[] Calcular_e_Ordenar(int n1, int n2, int n3)
        {
            List<int> lista_ordem = new List<int>();
            var vetor_ordem = new int[] {n1,n2,n3};

            for(int i = 0; i < 3; i++)
            {
                lista_ordem = vetor_ordem.ToList();
                lista_ordem.Sort();
                vetor_ordem = lista_ordem.ToArray();
            }

            return vetor_ordem;
        }
    }
}
