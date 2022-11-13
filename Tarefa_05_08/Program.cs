using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] totalDeVotos = new int[10];
            int candidato1 = 0, candidato2 = 0, votosBrancos = 0, votosNulos = 0;

            Console.WriteLine("----------Começo do Programa----------");
            Console.WriteLine(" ");

            Console.WriteLine("Escolha seu candidato!");
            Console.WriteLine(" ");
            Console.WriteLine("Digite 1 para o 1º candidato ou 2 para o 2º candidato.");
            Console.WriteLine("Digite 3 para votar em braco ou 4 para votar nulo.");
            Console.WriteLine(" ");

            for (int i = 0; i < totalDeVotos.Length; i++)
            {
                Console.Write("Voto do {0}º eleitor: ", i + 1);
                totalDeVotos[i] = int.Parse(Console.ReadLine());

                if ((totalDeVotos[i] < 1) || (totalDeVotos[i] > 4))
                {
                    Console.WriteLine("Você digitou um código inválido, tente novamente");
                    i--;
                }
            }

            for(int i = 0; i < totalDeVotos.Length; i++)
            {
                if (totalDeVotos[i] == 1)
                    candidato1++;
                else if (totalDeVotos[i] == 2)
                    candidato2++;
                else if (totalDeVotos[i] == 3)
                    votosBrancos++;
                else
                    votosNulos++;
            }

            Console.WriteLine(" ");

            Console.WriteLine("Total de votos do 1º candidato: " + candidato1);
            Console.WriteLine("Total de votos do 2º candidato: " + candidato2);
            Console.WriteLine("Total de votos em branco: " + votosBrancos);
            Console.WriteLine("Total de votos nulos: " + votosNulos);

            Console.WriteLine(" ");

            if (candidato1 > candidato2)
                Console.WriteLine("O 1º candidato foi o vencedor!!");
            if (candidato1 < candidato2)
                Console.WriteLine("O 2º candidato foi o vencedor!!");
            if(candidato1 == candidato2)
                Console.WriteLine("Ambos candidatos tiverem a mesma quantidade de votos!!");

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
