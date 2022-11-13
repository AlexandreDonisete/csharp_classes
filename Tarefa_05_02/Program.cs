using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] list = new double[20];
            double a = 0, b = 0, media;

            Console.WriteLine("----------Começo do Programa----------");

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                list[i] = double.Parse(Console.ReadLine());

                if (i == 0)
                    a = list[i];
                else if (i == 19)
                    b = list[i];
            }

            media = (a + b) / 2;

            Console.WriteLine(" ");

            Console.WriteLine("A média aritmética dos valores A e B é de: " + media);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}