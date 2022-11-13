using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, divisor = 0, posicoes = 1;
            double valoresNegativos = 0, mediaNegativos;
            double[] valores = new double[10];

            Console.WriteLine("----------COMEÇO DO PROGRAMA----------");

            // Introduzindo os 10 valores.
            for(i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                valores[i] = double.Parse(Console.ReadLine());
            };
            
            Console.WriteLine("");

            // Exibindo os valores menores que zero.
            for (i = 0; i < valores.Length; i++)
            {
                if(valores[i] < 0)
                {
                    Console.WriteLine("{0}º valor negativo: " + valores[i], posicoes++);
                }
            };

            // Soma todos os valores menores que zero na variável "valoresNegativos".
            // Incrementa +1 à variável "divisor".
            for(i = 0; i < valores.Length; i++)
            {
                if(valores[i] < 0)
                {
                    valoresNegativos += valores[i];
                    divisor++;
                }
            };

            // Realiza a média dos valores menores que zero e salva o valor na variável "mediaNegativos".
            mediaNegativos = valoresNegativos / divisor;

            // Exibi a média dos valores menores que zero.
            Console.WriteLine("A média dos valores menores que zero é igual a: " + mediaNegativos);

            Console.WriteLine("----------FIM DO PROGRAMA----------");
            Console.ReadKey();
        }
    }
}
