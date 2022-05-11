using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Mouse2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Projeto Mouse – Versão 2
             *obrigatório a utilização de uma ou mais estruturas de dados
             *obrigatório a utilização do paradigma procedural
             *projeto deve ser feito individualmente
             Proposta desta versão: Alterar o projeto Mouse
             Sua organização acaba de contratar um estagiário para trabalhar no Suporte de 
             Informática, com a intenção de fazer um levantamento nas sucatas encontradas nesta 
             área. A primeira tarefa dele é testar os mouses, testando e anotando o estado de cada 
             um deles, para verificar o que se pode aproveitar deles. Foi requisitado que você 
             desenvolva um programa em C# para registrar este levantamento.
             O programa deverá receber um número indeterminado de entradas, cada uma 
             contendo: um número de identificação do mouse.
             Os tipos de defeitos são:
             •necessita da esfera;
             •necessita de limpeza;
             •necessita troca do cabo ou conector;
             •quebrado ou inutilizado
             Agora vamos considerar que pode existir mouse sem defeito e podemos ter mouses 
             com um ou mais defeitos.
             Uma identificação igual a zero encerra o programa. Ao final o programa deverá emitir o 
             seguinte relatório:
             *Neste exemplo os Identificadores estão em ordem crescente, mas esse detalhe 
             será considerado um “extra”.
             ---- Identificação dos mouses sem defeito ----
             Nenhum
             Total: 0
             ---- Identificação dos mouses que necessitam de esfera ----
             101, 102, 108, 109, 110, 115 e 201
             Total: 7 mouses
             ---- Identificação dos mouses que necessitam de limpeza ----
             101, 102, 108, 109, 110, 115, 199, 200, 201 e 230
             Total: 10 mouses
             ---- Identificação dos mouses que necessitam troca de cabo ou conector ----
             102, 110, 200, 201 e 230
             Total: 5 mouses
             ---- Identificação dos mouses que estão quebrados ou inutilizados ----
             Nenhum
             Total: 0
             */

            List<int> numeroMouse = new List<int>();
            List<int> semDefeito = new List<int>();
            List<int> problemaEsfera = new List<int>();
            List<int> problemaLimpeza = new List<int>();
            List<int> problemaCabo = new List<int>();
            List<int> problemaQuebrado = new List<int>();

            int input = 0;
            string inputString = "";
            string inputStringToLower = "";
            int i = 0;
            int j = 0;
            int k = 0;
            int contador = 0;

            while (i == 0)
            {
                j = 0;

                while (j == 0)
                {
                    Console.WriteLine("Insira o número de identificação de no máximo 4 dígitos para o " + (contador + 1) + "º mouse (tecle 0 para terminar): ");
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());

                        if (input == 0)
                        {
                            goto relatorio;
                        }

                        else if (input > 1 && input < 10000)
                        {
                            numeroMouse.Add(input);
                            j = 1;
                        }

                        else
                        {
                            Console.WriteLine("O mouse deve ser identificado por um número maior que zero e com no máximo 4 dígitos.");
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
                    Console.WriteLine("O mouse apresenta algum problema? ");
                    Console.WriteLine("(S)im ");
                    Console.WriteLine("(N)ão ");

                    inputString = Console.ReadLine();
                    inputStringToLower = inputString.ToLower();

                    if (inputStringToLower == "s")
                    {
                        k = 0;

                        while (k == 0)
                        {
                            Console.WriteLine("O periférico apresenta problema na esfera?");
                            Console.WriteLine("(S)im ");
                            Console.WriteLine("(N)ão ");

                            inputString = Console.ReadLine();
                            inputStringToLower = inputString.ToLower();

                            if (inputStringToLower == "s")
                            {
                                problemaEsfera.Add(numeroMouse[contador]);
                                k = 1;
                            }

                            else if (inputStringToLower == "n")
                            {
                                k = 1;
                            }

                            else
                            {
                                Console.WriteLine("insira o valor \"s\" para sim ou \"n\" para não.");
                            }

                        }

                        k = 0;

                        while (k == 0)
                        {
                            Console.WriteLine("O periférico necessita de limpeza?");
                            Console.WriteLine("(S)im ");
                            Console.WriteLine("(N)ão ");

                            inputString = Console.ReadLine();
                            inputStringToLower = inputString.ToLower();

                            if (inputStringToLower == "s")
                            {
                                problemaLimpeza.Add(numeroMouse[contador]);
                                k = 1;
                            }

                            else if (inputStringToLower == "n")
                            {
                                k = 1;
                            }

                            else
                            {
                                Console.WriteLine("insira o valor \"s\" para sim ou \"n\" para não.");
                            }

                        }

                        k = 0;

                        while (k == 0)
                        {
                            Console.WriteLine("O periférico necessita de reparos no cabo ou conector?");
                            Console.WriteLine("(S)im ");
                            Console.WriteLine("(N)ão ");

                            inputString = Console.ReadLine();
                            inputStringToLower = inputString.ToLower();

                            if (inputStringToLower == "s")
                            {
                                problemaCabo.Add(numeroMouse[contador]);
                                k = 1;
                            }

                            else if (inputStringToLower == "n")
                            {
                                k = 1;
                            }

                            else
                            {
                                Console.WriteLine("insira o valor \"s\" para sim ou \"n\" para não.");
                            }

                        }

                        k = 0;

                        while (k == 0)
                        {
                            Console.WriteLine("O periférico está com partes quebradas ou está inutilizado?");
                            Console.WriteLine("(S)im ");
                            Console.WriteLine("(N)ão ");

                            inputString = Console.ReadLine();
                            inputStringToLower = inputString.ToLower();

                            if (inputStringToLower == "s")
                            {
                                problemaQuebrado.Add(numeroMouse[contador]);
                                k = 1;
                                j = 1;
                            }

                            else if (inputStringToLower == "n")
                            {
                                k = 1;
                                j = 1;
                            }

                            else
                            {
                                Console.WriteLine("insira o valor \"s\" para sim ou \"n\" para não.");
                            }
                        }
                    }

                    else if (inputStringToLower == "n")
                    {
                        semDefeito.Add(numeroMouse[contador]);
                        j = 1;
                    }

                    else
                    {
                        Console.WriteLine("insira o valor \"s\" para sim ou \"n\" para não.");
                    }
                }

                contador++;
            }

        relatorio:

            Console.WriteLine(" _______________________________________________________________________________");
            Console.WriteLine("|  RELATÓRIO                                                                    |");
            Console.WriteLine(" -------------------------------------------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("---Mouses sem defeitos----------------------------------------------------------");
            Console.Write("Número de Identificação:  ");
            semDefeito.Sort();
            semDefeito.ForEach(n => Console.Write(n + " "));
            Console.WriteLine(" ");
            Console.WriteLine("Total: " + semDefeito.Count()); ;
            Console.WriteLine(" ");

            Console.WriteLine("---Mouses com problemas na esfera-----------------------------------------------");
            Console.Write("Número de Identificação:  ");
            problemaEsfera.Sort();
            problemaEsfera.ForEach(n => Console.Write(n + " "));
            Console.WriteLine(" ");
            Console.WriteLine("Total: " + problemaEsfera.Count());
            Console.WriteLine(" ");

            Console.WriteLine("---Mouses que necessitam de limpeza---------------------------------------------");
            Console.Write("Número de Identificação:  ");
            problemaLimpeza.Sort();
            problemaLimpeza.ForEach(n => Console.Write(n + " "));
            Console.WriteLine(" ");
            Console.WriteLine("Total: " + problemaLimpeza.Count());
            Console.WriteLine(" ");

            Console.WriteLine("---Mouses que necessitam de reparo do cabo ou conector--------------------------");
            Console.Write("Número de Identificação:  ");
            problemaCabo.Sort();
            problemaCabo.ForEach(n => Console.Write(n + " "));
            Console.WriteLine(" ");
            Console.WriteLine("Total: " + problemaCabo.Count());
            Console.WriteLine(" ");

            Console.WriteLine("---Mouses com partes quebradas ou que estão inutilizados------------------------");
            Console.Write("Número de Identificação:  ");
            problemaQuebrado.Sort();
            problemaQuebrado.ForEach(n => Console.Write(n + " "));
            Console.WriteLine(" ");
            Console.WriteLine("Total: " + problemaQuebrado.Count());
            Console.WriteLine(" ");

        }
    }
}
