using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] numerosReais = new double[10];
            double[] quadrados = new double[10];

            Console.WriteLine("----------Começo do Programa----------");

            // Inserindo os 10 valores no array "numerosReais".
            for (i = 0; i < numerosReais.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                numerosReais[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            // Efetuando a conta do quadrado de cada elemento do array "numerosReais".
            // Salvando o valor no array "quadrados".
            for (i = 0; i < numerosReais.Length; i++)
                quadrados[i] = numerosReais[i] * numerosReais[i];

            Console.WriteLine("");

            // Exibindo o array do conjunto dos números reais
            Console.WriteLine("Array do conjunto dos números reais:");
            for (i = 0; i < numerosReais.Length; i++)
                Console.WriteLine("{0}º número: {1}", i + 1, numerosReais[i]);

            Console.WriteLine("");

            // Exibindo o array do conjunto dos números reais
            Console.WriteLine("Array dos quadrados: ");
            for (i = 0; i < numerosReais.Length; i++)
                Console.WriteLine("{0}º número: {1}", i + 1, quadrados[i]);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
