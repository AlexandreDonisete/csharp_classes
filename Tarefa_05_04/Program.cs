using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[20];
            double somaNotas = 0, mediaGeral = 0, maiorNota = 0 ;

            Console.WriteLine("----------Começo do Programa----------");

            for(int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a {0}ª nota: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());

                if (notas[i] > maiorNota)
                    maiorNota = notas[i];

                somaNotas += notas[i];
            }
            mediaGeral = (somaNotas / 20);

            Console.WriteLine(" ");

            Console.WriteLine("A média geral dos alunos é igual a: " + mediaGeral);

            Console.WriteLine(" ");

            Console.WriteLine("A maior das notas foi: " + maiorNota);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
