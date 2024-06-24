using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4) Vetor Invertido: Implemente um programa que inverta a ordem dos elementos em um vetor.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio04
    {
        public static void Main(string[] args)
        {
            int[] vetor = { 10, 50, 90, 40, 20 };

          
            Array.Reverse(vetor);

           
            Console.Write("Vetor invertido: ");

            foreach (int numero in vetor)
            {
            Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
