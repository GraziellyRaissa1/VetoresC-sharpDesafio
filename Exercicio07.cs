using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Ordenação Crescente: Implemente um algoritmo que ordene os elementos de um vetor em ordem crescente.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
          
        int[] numerosDesordenados = { 590, 22, 8, 1, 3000 };

           
            Array.Sort(numerosDesordenados);

          
            Console.Write("Vetor ordenado em ordem crescente: ");
            foreach (int numero in numerosDesordenados)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
