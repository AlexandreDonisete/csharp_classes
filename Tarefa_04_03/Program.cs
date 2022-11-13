using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------COMEÇO DO PROGRAMA----------");
            int i = 0;
            double[] lista = new double[8];

            for(i = 0; i < lista.Length; i++)
            {;
                Console.Write("Digite o {0}º número: ", i + 1);
                lista[i] = double.Parse(Console.ReadLine());
            };

            double x = lista[0];
            double y = lista[7];
            double z = x + y;

            Console.WriteLine("A soma entre a primeira e a última posição do array é igual a: " + z);


            Console.WriteLine("----------FIM DO PROGRAMA----------");
            Console.ReadKey();
        }
    }
}
