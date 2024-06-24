using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10) União de Vetores: Crie um programa que una dois vetores em um terceiro vetor, mantendo a ordem dos elementos.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            
            int[] primeiroVetor = { 10, 22, 73 };
            int[] segundoVetor = { 45, 51, 67 };

            int[] vetorResultado = new int[primeiroVetor.Length + segundoVetor.Length];

            
            Array.Copy(primeiroVetor, vetorResultado, primeiroVetor.Length);

            Array.Copy(segundoVetor, 0, vetorResultado, primeiroVetor.Length, segundoVetor.Length);

            Console.Write("Vetor união: ");
            foreach (int numero in vetorResultado)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine(); 
        }
    }
}

