using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10];
            int somaImpares = 0;
            float mediaImpares, impares = 0;

            Console.WriteLine("----------Começo do Programa----------");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());

                if (list[i] <= 0)
                {
                    Console.WriteLine("Digite um número inteiro maior que zero!");
                    Console.WriteLine(" ");
                    i--;
                };
            }

            Console.WriteLine(" ");

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 2 != 0)
                {
                    somaImpares += list[i];
                    impares++;
                }
            }

            mediaImpares = somaImpares / impares;

            Console.WriteLine("A media aritmética de todos os números ímpares da lista é igual a: " + mediaImpares);

            Console.ReadLine();
            Console.WriteLine("----------Fim do Programa----------");
        }
    }
}
