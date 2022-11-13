using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] habitantes = new int[800];
            int[] idade = new int[800];
            double[] altura = new double[800];
            int feminino = 0, masculino = 0;
            double mediaIdadeGrupo, alturaFem = 0, mediaAlturaFem, idadeGrupo = 0, idadeMasc = 0, mediaIdadeMasc, pessoasEntre_18_35 = 0, percentualEntre_18_35;

            Console.WriteLine("----------Começo do Programa----------");
            Console.WriteLine("");
            Console.WriteLine("Informe seus dados!");
            Console.WriteLine("Digite 0 para o sexo feminino e 1 para o sexo masculino.");
            Console.WriteLine("");

            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.Write("Sexo do {0}º habitante: ", i + 1);
                habitantes[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (habitantes[i] != 0 && habitantes[i] != 1)
                {
                    Console.WriteLine("Código inválido tente novamente!");
                    i--;
                    Console.WriteLine("");
                } else if (habitantes[i] == 0)
                {
                    masculino++;
                } else if (habitantes[i] == 1)
                {
                    feminino++;
                }
                    
            };

            Console.WriteLine("Digite sua idade!");

            Console.WriteLine("");

            for (int i = 0; i < idade.Length; i++)
            {
                Console.Write("Idade do {0}º habitante: ", i + 1);
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if ((idade[i] <= 18) || (idade[i] >= 35))
                    pessoasEntre_18_35++;

                if (habitantes[i] == 0)
                    idadeMasc += idade[i];

                idadeGrupo += idade[i];
            }

            Console.WriteLine("Digite sua altura!");

            Console.WriteLine("");

            for (int i = 0; i < altura.Length; i++)
            {
                Console.Write("Altura do {0}º habitante: ", i + 1);
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (habitantes[i] == 1)
                    alturaFem += altura[i];
            }

            mediaIdadeGrupo = (idadeGrupo / idade.Length);
            mediaAlturaFem = (alturaFem / feminino);
            mediaIdadeMasc = (idadeMasc / masculino);
            percentualEntre_18_35 = (pessoasEntre_18_35 / habitantes.Length) * 100;

            Console.WriteLine("A média da idade do grupo é igual a: " + mediaIdadeGrupo + " anos");
            Console.WriteLine("");

            Console.WriteLine("A média da altura das mulheres é igual a: " + mediaAlturaFem + " metros");
            Console.WriteLine("");

            Console.WriteLine("A média da idade do dos homem é igual a: " + mediaIdadeMasc + " anos");
            Console.WriteLine("");


            Console.WriteLine("O percentual de pessoas com idade entre 18 e 35 anos (inclusive) é igual a: " + percentualEntre_18_35 + "%");
            Console.WriteLine("");

            Console.WriteLine("----------Fim do Programa----------");
            Console.ReadKey();
        }
    }
}
