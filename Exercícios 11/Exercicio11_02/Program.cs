using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] Q = new double[10];
            double menor = 0, maior = 0, maiorPosicao = 0;

            // Entre com os 10 valores do array Q, todos maiores que 0.
            Console.WriteLine("Valores do array Q: ");
            for (i = 0; i < Q.Length; i++)
            {
                Console.Write((i + 1) + "º número: ");
                Q[i] = double.Parse(Console.ReadLine());

                if (Q[i] < 0)
                {
                    Console.WriteLine("Não digite números menores que zero!");
                    Console.ReadKey();
                    return;
                }

            };

            Console.WriteLine("");

            //* Criar um loop que, compara o valor do índice atual com o valor da variável "menor" ou "maior".
            //* Caso o valor do índice atual seja menor que a variável "menor", o valor da variável será substituido pelo valor do índice atual.
            //* Caso o valor do índice atual seja maior que a variável "maior", o valor da variável será substituido pelo valor do índice atual,
            //* e o valor da variável "maiorPosicao" será substituído pelo índice atual do array. */
            for (i = 0; i < Q.Length; i++)
            {
                if (Q[i] < menor)
                {
                    menor = Q[i];

                } else if (Q[i] > maior)
                {
                    maior = Q[i];
                    maiorPosicao = i;
                };
            };

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O número está na " + maiorPosicao + "ª posição do array.");
            Console.ReadKey();
        }
    }
}
