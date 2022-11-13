using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] list = new double[20];
            int c = 0;
            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < list.Length; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                list[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < list.Length; i++)
            {
                for(int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] == list[j])
                        Console.WriteLine("O número {0} se repete!", list[i]);
                    else
                        c++; 
                }          
            }

            if (c == 190)
                Console.WriteLine("Nenhum número se repete!");

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
