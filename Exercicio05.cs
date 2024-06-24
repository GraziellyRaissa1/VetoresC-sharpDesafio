using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Elementos Pares: Escreva um programa que conte e exiba a quantidade de números pares em um vetor de inteiros.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int contadorNumeroPar = 0;

            foreach (int Contadora in vetor)
            {
                if (Contadora % 2 == 0)
                {
                    contadorNumeroPar++;
                }
            }

            Console.WriteLine($"A quantidade de números pares no vetor é: {contadorNumeroPar}");
        }
    }
   
}

