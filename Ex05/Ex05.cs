using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Faça um algoritmo que leia o tempo de duração de 
/// um evento em uma fábrica expressa em segundos e 
/// mostre-o expresso em 
/// horas, minutos e segundos.
/// </summary>

namespace Ex05
{
    public class Horario
    {
        int segundos,horas,minutos;

        public int Calcular_Hora(int seg)
        {
            segundos = seg;
            horas = seg / 3600;
            return horas;
        }

        public int Calcular_Minutos()
        {
            minutos = (segundos % 3600) / 60;
            return minutos;
        }
        public int Calcular_Segundos()
        {
            segundos = (segundos % 3600) % 60;
            return segundos;
        }
    }
}
