using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------COMEÇO DO PROGRAMA----------");

            int i, valor;

            int[] array = new int[10];

            Console.WriteLine("Digite 10 valores numéricos inteiros: ");

            for(i = 0; i < 10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            };


            Console.WriteLine("Elementos armazenados no array");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            };

            Console.WriteLine("Entre com o valor a ser consultado no array: ");
            valor = int.Parse(Console.ReadLine());

            for(i = 0; i < 10; i++)
            {
                if(valor == array[i])
                {
                    Console.WriteLine("O número {0} está contido no array!", valor);
                    Console.WriteLine("----------FIM DO PROGRAMA----------");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("O valor {0} não está contido no array!", valor);
            Console.WriteLine("----------FIM DO PROGRAMA----------");
            Console.ReadKey();
            return;

            

        }
    }
}
