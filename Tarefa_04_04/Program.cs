using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10];

            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());
            };
            
            Console.WriteLine();

            Console.WriteLine("Lista invertida: ");
            for (int i = 9 ; i >= 0; i--)
            {
                Console.WriteLine("{0}º número: {1} ", i + 1, list[i]);
            };

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
