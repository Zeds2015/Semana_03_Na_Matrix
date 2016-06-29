using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Fazer um programa que leia três valores numéricos, determine e imprima o menor deles.
/// </summary>

namespace Ex01
{
    public class Ex01
    {
        public int Calcular(params int[] num)
        {
            int menor = num.Min();
            return menor;
        }
    }
}
