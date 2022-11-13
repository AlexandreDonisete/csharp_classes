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
            int somaPar = 0;

            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < list.Length; i++)
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

            for(int i = 0; i < list.Length; i++)
            {
                if(list[i] % 2 == 0 )
                {
                    somaPar += list[i];
                }
            }

            Console.WriteLine("A soma de todos os números pares da lista é igual a: " + somaPar);

            Console.ReadLine();
            Console.WriteLine("----------Fim do Programa----------");
        }
    }
}
