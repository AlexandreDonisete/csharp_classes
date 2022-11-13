using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double media = 0, acimaMedia = 0;
            double[] notas = new double[10];

            // Digitar as notas da turma.
            Console.WriteLine("Digite as notas dos 10 alunos: ");
            for(i = 0; i < 10; i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
            };

            Console.WriteLine();

            // Efetuar a média das notas da turma.
            for (i = 0; i < 10; i++)
            {
                media += (notas[i]) / 10;
            };
            Console.WriteLine("A média da turma é: " + media);

            Console.WriteLine();

            // Testar se as notas da turma estão acima da média ou não. Caso esteja, acrescentar +1 na váriável "acimaMedia".
            for (i = 0; i < 10; i++)
            {
                if(notas[i] > media)
                {
                    acimaMedia += 1;
                }
            };

            // Exibir as notas da turma.
            Console.WriteLine("Notas da turma: ");
            for (i = 0; i < 10; i++)
            {
                if (notas[i] > media)
                {
                    Console.WriteLine("Está nota está acima da média calculada: " + notas[i]);
                } else
                {
                    Console.WriteLine("Está nota não está acima da média calculada: " + notas[i]);
                }
                
            };

            Console.WriteLine();

            Console.WriteLine("Houveram {0} notas acima da média calculada", acimaMedia);

            Console.ReadKey();
        }
    }
}
