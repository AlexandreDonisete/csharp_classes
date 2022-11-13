using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double media = 0;
            double[] list = new double[15];

            Console.WriteLine("----------Começo do Programa----------");

            for(i = 0; i < list.Length; i++)
            {
                Console.Write("Digite a {0}ª nota: ", i + 1);
                list[i] = double.Parse(Console.ReadLine());
            };
            
            for(i = 0; i < list.Length; i++)
                media += list[i];

            media = (media) / 15;

            Console.WriteLine(" ");

            Console.WriteLine("A média da sala é de: " + media);

            for(i = 0; i < list.Length; i++)
            {
                if(media > list[i])
                    Console.WriteLine("A {0}ª nota está abaixo da média: {1} ", i + 1, list[i]);
            };

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
