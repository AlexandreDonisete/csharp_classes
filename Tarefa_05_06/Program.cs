using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] list = new double[10];

            Console.WriteLine("----------Começo do Programa----------");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                list[i] = double.Parse(Console.ReadLine());

                if (list[i] % 2 == 0)
                    list[i] = 99;
            }

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine("{0}º número: " + list[i], i + 1);


            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
