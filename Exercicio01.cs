using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Soma dos Elementos: Escreva um programa que calcule a soma de todos os elementos de um vetor de inteiro

namespace VetoresC_sharpDesafio
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            int[] numeroInteiro = { 5, 10, 3, 400, 15 };

  
            int soma = 0;

            foreach (int contadora in numeroInteiro)
            {
                soma += contadora;
            }
            Console.WriteLine("A soma dos elementos do vetor é: " + soma);
        }
    }
}
