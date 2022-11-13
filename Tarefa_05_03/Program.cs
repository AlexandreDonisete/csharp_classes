using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[99];
            int j = 99;

            Console.WriteLine("----------Começo do Programa----------");

            for (int i = 0; i < 99; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");

            Array.Reverse(list);

            Console.WriteLine("Array invertido:");

            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine("{0}º valor: " + list[i], j);
                j--;
            }


            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}