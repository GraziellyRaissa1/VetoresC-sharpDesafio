using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8) Buscar Elemento: Escreva um programa que verifique se um determinado elemento está presente em um vetor.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
        
            int[] numeros = { 33, 62, 82, 73, 1111, 53 };

           
            int numeroProcurado = 33;

          
            bool encontrado = false;
            foreach (int numero in numeros)
            {
                if (numero == numeroProcurado)
                {
                    encontrado = true;
                    break;
                }

            }
            if (encontrado)
            {
                Console.WriteLine($"O elemento {numeroProcurado} está presente no vetor.");
            }
            else
            {
                Console.WriteLine($"O elemento {numeroProcurado} não está presente no vetor.");
        }   }
    }
}
