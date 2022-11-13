using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Começo do Programa----------");

            double[] numeros = new double[15];
            double[] numerosCubo = new double[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite o valor do {0}º número: ", i + 1);
                numeros[i] = double.Parse(Console.ReadLine());

                numerosCubo[i] = Math.Pow(numeros[i], 3);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Lista de Números: ");

            Console.WriteLine(" ");

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine("{0}º número da lista: " + numeros[i], i + 1);

            Console.WriteLine(" ");

            Console.WriteLine("Lista de Cubos dos Números: ");

            Console.WriteLine(" ");

            for (int i = 0; i < numeros.Length; i++)
                Console.WriteLine("{0}º número da lista de cubos: " + numerosCubo[i], i + 1);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
