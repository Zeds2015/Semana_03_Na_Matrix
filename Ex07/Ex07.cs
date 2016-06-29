using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Elabore um algoritmo que dada a idade de um nadador classifica-o em uma das seguintes categorias:
///infantil A = 5 - 7 anos
///infantil B = 8-10 anos
///juvenil A = 11-13 anos
///juvenil B = 14-17 anos
///adulto = maiores de 18 anos
/// </summary>

namespace Ex07
{
    public class Nadar
    {
        
        public string Calcular_Idade_Nadador(int idade)
        {
            string categoria;

            if(idade >= 5 && idade <= 7)
            {
                categoria = "Infantil A";
            }

            else if(idade <= 10)
            {
                categoria = "Infantil B";
            }

            else if(idade <= 13)
            {
                categoria = "Juvenil A";
            }

            else if(idade <= 17)
            {
                categoria = "Juvenil B";
            }

            else
            {
                categoria = "Adultos";
            }

            return categoria;
            }
        }
    }

