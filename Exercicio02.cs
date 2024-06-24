using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2) Maior e Menor Valor: Crie um programa que encontre o maior e o menor valor em um vetor de números inteiros.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            
            int[] numero = { 1600, 327, 180, 1, 0 };

           
            int maiorNumero = numero[0];

            int menorNumero = numero[0]; 
           

            foreach (int elemento in numero)
            {
                if (elemento > maiorNumero)
                {
                    maiorNumero = elemento;
                }

                if (elemento < menorNumero)
                {
                    menorNumero = elemento;
                }
            }
            Console.WriteLine("O maior número no vetor é: " + maiorNumero);

            Console.WriteLine("O menor número no vetor é: " + menorNumero);
        }
    }
}

