using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10];

            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());

                if (list[i] < 0)
                    list[i] = 99;

                else if (list[i] % 2 == 0)
                    list[i] = 33;
            }

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine("{0}º número: " + list[i], i + 1);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
