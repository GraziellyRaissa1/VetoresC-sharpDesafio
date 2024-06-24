using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9) Remover Elemento: Desenvolva um programa que remova todas as ocorrências de um elemento específico de um vetor.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio09
    {
        public static void Main(string[] args)
        {
       
            int[] numeros = { 33, 67, 25, 18, 11, 45, 83, 89, 300 };

         
            int numeroParaRemover = 300;

            List<int> numerosFiltrados = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero != numeroParaRemover)
                {
                    numerosFiltrados.Add(numero);
                }
            }

     
            Console.Write("Vetor após remover o elemento " + numeroParaRemover + ": ");
            foreach (int numero in numerosFiltrados)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine(); 
        }
    }
}
