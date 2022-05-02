using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Loops8
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             8). Foi realizada uma pesquisa em 15 (quinze) cidades brasileiras para coletar dados sobre 
                acidentes de transito. Foram obtidos os seguintes dados: 
                a) Nome da cidade
                b) Número de veículos de passeio (em 2019)
                c) Número de acidentes de transito com vítimas (em 2019).
                Deseja-se saber: 
                A). Qual a cidade que possui o maior número de acidentes de transito 
                B). Qual a cidade que possui o menor número de acidentes de transito 
                C). Qual a média de veículos nas quinzes cidades juntas 
                D). Qual a média de acidentes de transito nas cidades com menos de 2.000 veículos de 
                passeio.
            */

            string[] nomeCidade = new string[15]
            {
                "Tomar do Geru",
                "São Miguel do Gostoso",
                "Recursolândia",
                "Barrolândia",
                "Pintópolis",
                "Anta Gorda",
                "Bem-Bom",
                "Chão de Alegria",
                "Sombrio",
                "Feliz Deserto",
                "Não me Toque",
                "Nenelândia",
                "Piranhas",
                "Pau Grande",
                "Veado Velho"
            };

            int[] numVeiculosCidade = new int[15]
            {
                54634,
                120056,
                1870,
                389000,
                44098,
                409856,
                6054,
                540435,
                344005,
                1998,
                490968,
                2090897,
                409876,
                109786,
                550873,
            };

            int[] acidentesCidade = new int[15]
            {
                234,
                46,
                434,
                7,
                34,
                785,
                72,
                864,
                76,
                753,
                19,
                32,
                8,
                19,
                9,
            };


            /*A). Qual a cidade que possui o maior número de acidentes de transito
                B). Qual a cidade que possui o menor número de acidentes de transito
                C). Qual a média de veículos nas quinzes cidades juntas
                D). Qual a média de acidentes de transito nas cidades com menos de 2.000 veículos de
                passeio.
            */

            int i = 0;
            string input;
            int totalVeiculosCidade = 0;
            int totalAcidentesCidade = 0;

            while (i == 0) 
            {
                //contador abaixo é usado para index dos arrays
                int j = 0;
                int k = 0;

                Console.Clear();

                Console.WriteLine(" ________________________________________________________");
                Console.WriteLine("|Sistema de Informações de Transito SISINFTRANSIT 5.24086|");
                Console.WriteLine(" --------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha uma opção pela numeração abaixo:");
                Console.WriteLine("(1): Lista completa de informações das cidades cadastradas em 2019");
                Console.WriteLine("(2): Ver a cidade com maior número de acidentes em 2019");
                Console.WriteLine("(3): Ver a cidade com menor número de acidentes em 2019");
                Console.WriteLine("(4): Ver a média de veículos de todas as cidades juntas");
                Console.WriteLine("(5): Ver a média de acidentes de transito nas cidades com menos de 2.000 veículos de passeio.");
                Console.WriteLine("(6): Sair do Programa.");
                
                input = Console.ReadLine();
                Console.WriteLine(" ");

                if (input == "1")
                {
                    Console.WriteLine(nomeCidade[0] + ": " + numVeiculosCidade[0] + " veículos; " + acidentesCidade[0] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[1] + ": " + numVeiculosCidade[1] + " veículos; " + acidentesCidade[1] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[2] + ": " + numVeiculosCidade[2] + " veículos; " + acidentesCidade[2] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[3] + ": " + numVeiculosCidade[3] + " veículos; " + acidentesCidade[3] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[4] + ": " + numVeiculosCidade[4] + " veículos; " + acidentesCidade[4] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[5] + ": " + numVeiculosCidade[5] + " veículos; " + acidentesCidade[5] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[6] + ": " + numVeiculosCidade[6] + " veículos; " + acidentesCidade[6] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[7] + ": " + numVeiculosCidade[7] + " veículos; " + acidentesCidade[7] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[8] + ": " + numVeiculosCidade[8] + " veículos; " + acidentesCidade[8] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[9] + ": " + numVeiculosCidade[9] + " veículos; " + acidentesCidade[9] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[10] + ": " + numVeiculosCidade[10] + " veículos; " + acidentesCidade[10] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[11] + ": " + numVeiculosCidade[11] + " veículos; " + acidentesCidade[11] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[12] + ": " + numVeiculosCidade[12] + " veículos; " + acidentesCidade[12] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[13] + ": " + numVeiculosCidade[13] + " veículos; " + acidentesCidade[13] + " acidentes registrados;");
                    Console.WriteLine(nomeCidade[14] + ": " + numVeiculosCidade[14] + " veículos; " + acidentesCidade[14] + " acidentes registrados;");
                   

                }

                else if (input == "2")
                {
                    int valorMaior = acidentesCidade.Max();
                    int index = acidentesCidade.findIndex(valorMaior);

                    Console.WriteLine(nomeCidade[index]);
                }

                else if (input == "3")
                {
                    int valorMaior = acidentesCidade.Min();
                    int index = acidentesCidade.findIndex(valorMaior);

                    Console.WriteLine(nomeCidade[index]);
                }

                else if (input == "4")
                {
                    for (j = 0; j < 15; j++)
                    {
                        totalVeiculosCidade += numVeiculosCidade[j];
                    }
                    
                    Console.WriteLine(totalVeiculosCidade / 15);
                }

                else if (input == "5")
                {
                    for (j = 0; j < 15; j++)
                    {
                        if(numVeiculosCidade[j] < 2000)
                        {
                            totalAcidentesCidade += acidentesCidade[j];
                            k++;
                        }
                    }

                    Console.WriteLine(totalAcidentesCidade / k);
                }

                else if (input == "6")
                {
                   Environment.Exit(0);
                }

                Console.ReadLine();
            }
        }
    }
}
