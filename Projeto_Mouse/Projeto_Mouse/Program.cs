using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Mouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Projeto Mouse
             *obrigatório a utilização de uma ou mais estruturas de dados
             *obrigatório a utilização do paradigma procedural
             *projeto deve ser feito individualmente
             *
             Sua organização acaba de contratar um estagiário para trabalhar no Suporte de
             Informática, com a intenção de fazer um levantamento nas sucatas encontradas nesta
             área. A primeira tarefa dele é testar os mouses, testando e anotando o estado de cada
             um deles, para verificar o que se pode aproveitar deles. Foi requisitado que você
             desenvolva um programa em C# para registrar este levantamento.
             O programa deverá receber um número indeterminado de entradas, cada uma
             contendo um número de identificação do mouse e o tipo de defeito:
             •necessita da esfera;
             •necessita de limpeza;
             •necessita troca do cabo ou conector;
             •quebrado ou inutilizado
             
             Uma identificação igual a zero encerra o programa. Ao final o programa deverá emitir o
             seguinte relatório:
             Quantidade de mouses: 100
             Situação: Quantidade Percentual
             1-Necessita da esfera 40 40%
             2-Necessita de limpeza 30 30%
             3-Necessita troca do cabo ou conector 15 15%
             4-Quebrado ou inutilizado 15 15%*/

            List<int> mouse = new List<int>();
            List<int> problema = new List<int>();

            int input = 0;
            int i = 0;
            int j = 0;

            while (i == 0)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Insira o número de identificação do mouse (0 para terminar): ");
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());

                        if (input == 0)
                        {
                            goto relatorio;
                        }

                        else
                        {
                            mouse.Add(input);
                            j = 1;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("O mouse deve ser identificado por um número inteiro.");
                    }
                }

                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Indique qual a situação do mouse: ");
                    Console.WriteLine("(1) Necessita de esfera nova ");
                    Console.WriteLine("(2) Necessita de limpeza");
                    Console.WriteLine("(3) Necessita de reparo do cabo ou conector");
                    Console.WriteLine("(4) Periférico quebrado ou inutilizado");

                    try
                    {
                        input = Int32.Parse(Console.ReadLine());

                        if (input == 1)
                        {
                            problema.Add(1);
                            j = 1;
                        }

                        else if (input == 2)
                        {
                            problema.Add(2);
                            j = 1;
                        }

                        else if (input == 3)
                        {
                            problema.Add(3);
                            j = 1;
                        }

                        else if (input == 4)
                        {
                            problema.Add(4);
                            j = 1;
                        }

                        else 
                        {
                            Console.WriteLine("O problema do mouse deve ser identificado por um número inteiro de 1 a 4.");
                        }


                    }
                    catch
                    {
                        Console.WriteLine("O problema do mouse deve ser identificado por um número inteiro de 1 a 4.");
                    }
                }
            }

        relatorio:

            int esfera = 0;
            int limpeza = 0;
            int conector = 0;
            int quebrado = 0;

            for (i = 0; i < mouse.Count(); i++)
            {
                if (problema[i] == 1)
                {
                    esfera += 1;
                }

                else if (problema[i] == 2)
                {
                    limpeza += 1;
                }

                else if (problema[i] == 3)
                {
                    conector += 1;
                }

                else if (problema[i] == 4)
                {
                    quebrado += 1;
                }
            }

            int esferaPorcento = esfera * 100 / mouse.Count();
            int limpezaPorcento = limpeza * 100 / mouse.Count();
            int conectorPorcento = conector * 100 / mouse.Count();
            int quebradoPorcento = quebrado * 100 / mouse.Count();

            Console.WriteLine(" ");
            Console.WriteLine("RELATÓRIO");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Quantidade de mouses:   " + mouse.Count());
            Console.WriteLine("Situação                              Quantidade          Percentual");
            Console.WriteLine("Necessita de esfera:                  " + esfera + "                   " + esferaPorcento);
            Console.WriteLine("Necessita de limpeza:                 " + limpeza + "                   " + limpezaPorcento);
            Console.WriteLine("Necessita troca do cabo ou conector:  " + conector + "                   " + conectorPorcento);
            Console.WriteLine("Quebrado ou inutilizado:              " + quebrado + "                   " + quebradoPorcento);
        }
    }
}
