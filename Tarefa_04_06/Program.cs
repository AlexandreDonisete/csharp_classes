using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------COMEÇO DO PROGRAMA----------");

            int[] list = new int[10];
            int i, x, c = 0;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                list[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");


            for (i = 0; i < 10; i++)
            {
                for(x = i + 1; x < list.Length; x++)
                {
                    if (list[i] == list[x])
                    {
                        Console.WriteLine("O número {0} se repete!!", list[i]);
                    }
                    else
                        c += 1;
                }
            }

            Console.WriteLine(" ");

            if (c == 45)
                Console.WriteLine("Nenhum valor se repete!!");

            Console.ReadKey();
            Console.WriteLine("----------FIM DO PROGRAMA----------");
        }
    }
}
