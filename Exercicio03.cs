using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3) Média dos Elementos: Desenvolva um programa que calcule a média dos elementos em um vetor de números reais.


namespace VetoresC_sharpDesafio
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            double[] vetor = { 53.5, 12.5, 70.20, 39.5, 18.8 };

           
            double soma = 0;

          
            foreach (double elemento in vetor)
            {
                soma += elemento;
            }

            double media = soma / vetor.Length;

        
            Console.WriteLine($"A média dos números do vetor é: {media}");
        }
    }
}
