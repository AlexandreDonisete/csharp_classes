using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Começo do Programa----------");

            double[] listClientPayment = new double[300];
            double totalClientPayment = 0;  

            for(int i = 0; i < listClientPayment.Length; i++)
            {
                Console.Write("{0}º valor pago: ", i + 1);
                listClientPayment[i] = double.Parse(Console.ReadLine());

                totalClientPayment += listClientPayment[i];
            }

            Console.WriteLine(" ");

            Console.WriteLine("A receita total da danceteria nesta noite foi de {0}R$.", totalClientPayment);

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
