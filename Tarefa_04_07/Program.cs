using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10];

            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());

                if(list[i] < 0)
                    list[i] = 0;
            }

            Console.WriteLine(" ");

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("{0}º valor: " + list[i], i + 1);
                Console.WriteLine(" ");
            }

            Console.ReadLine();
            Console.WriteLine("----------Fim do Programa----------");
        }
    }
}
