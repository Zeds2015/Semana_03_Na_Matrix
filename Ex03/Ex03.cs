using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    /// <summary>
   /// Escreva um algoritmo que leia três números inteiros e positivos (A, B, C) 
   /// e calcule a seguinte expressão: D = R + S / 2
  ///onde:
  ///R = (A + B)²
 ///S = (B + C)²
 /// </summary>
 
    public class Calcula_D
    {
        public double Calcular(int x, int y, int z)
        {
            double R, S, D;

            R = Math.Pow(x+y, 2);
            S = Math.Pow(y+z, 2);

            D = R + S / 2;

            return D;
        }
    }
}
