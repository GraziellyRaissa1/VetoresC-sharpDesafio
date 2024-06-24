using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Frequência de Elementos: Crie um programa que determine a frequência de cada elemento único em um vetor.

namespace VetoresC_sharpDesafio
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 24, 33, 42, 75, 88, 12, 93, 69, 56 };

            Dictionary<int, int> contagemNumeros = new Dictionary<int, int>();

            foreach (int numero in numeros)
            {
                if (contagemNumeros.ContainsKey(numero))
                {
                    contagemNumeros[numero]++;
                }
                else
                {
                    contagemNumeros[numero] = 5;
                }
            }

            Console.WriteLine("Frequência dos elementos no vetor:");
            foreach (var par in contagemNumeros)
            {
                Console.WriteLine($"Elemento: {par.Key}, Frequência: {par.Value}");
            }
        }
    }
}
