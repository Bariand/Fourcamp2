using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Mouse3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Projeto Mouse – Versão 3
            //* obrigatório a utilização de uma ou mais estruturas de dados
            //* obrigatório a utilização do paradigma orientado a objetos
            //* projeto deve ser feito individualmente
            //Proposta desta versão: Alterar o projeto Mouse 2
            //Agora iremos trocar do paradigma procedural para o orientado a objetos.
            //Implemente o diagrama de classes a seguir e faça as alterações necessárias no seu
            //código para utilizá-las corretamente.
            //O cadastro de mouses deve verificar se o id informado já está cadastrado ou não.
            //Se sim, o sistema deve informar a mensagem: “O mouse com este identificador já está
            //cadastrado. ” E voltar a pedir um id.
            //Após o relatório já exibido na etapa anterior, o resumo com as informações
            //correspondente ao seu contexto de mouses cadastrados deve ser exibido:
            //Relatório – Resumo
            //Quantidade de mouses cadastrados: 10
            //% de mouses sem defeito: 0 %
            //% de mouses com apenas um defeito: 10 %

            //List<int> semDefeito = new List<int>();
            //List<int> problemaEsfera = new List<int>();
            //List<int> problemaLimpeza = new List<int>();
            //List<int> problemaCabo = new List<int>();
            //List<int> problemaQuebrado = new List<int>();

            int input = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int contador = 0;
            List<int> id = new List<int>();
            List<Mouse> mouseList = new List<Mouse>();
            bool defeitoEsfera = false;
            bool defeitoLimpeza = false;
            bool defeitoCabo = false;
            bool defeitoQuebrado = false;
            int semDefeito = 0;
            int apenasUmDefeito = 0;

            while (i == 0)
            {
                Console.Clear();
                j = 0;

                while (j == 0)
                {
                    j = 0;

                    Console.WriteLine("Insira o número de identificação de no máximo 4 dígitos para o " + (contador + 1) + "º mouse (tecle 0 para terminar): ");
                   
                    try
                    {
                        input = Int32.Parse(Console.ReadLine());

                        
                        if (input == 0)
                        {
                            goto relatorio; //Vai para o relatório e termina o programa
                        }
                        
                        else if (input >= 1000 && input <= 9999)
                        {

                            if (id.Contains(input)) //testa se a ID do mouse já existe
                            {
                                Console.WriteLine("O número de identificação já existe. Aperte qualquer tecla para continuar.");
                                Console.ReadLine();
                            }

                            else
                            {
                                id.Add(input);
                                j = 1;
                            }
                        }

                        else
                        {
                            Console.WriteLine("O valor inserido é inválido. Aperte qualquer tecla para continuar.");
                            Console.ReadLine();
                        }

                    }
                    catch
                    {
                        Console.WriteLine("O mouse deve ser identificado por um número inteiro. Aperte qualquer tecla para continuar.");
                        Console.ReadLine();
                    }
                }

                j = 0;

                while (j == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Indique os problemas que o mouse apresenta e aperte \"0\" (continuar) após tê-los selecionado: ");
                    Console.WriteLine("(1) NecessitaEsfera = " + defeitoEsfera);
                    Console.WriteLine("(2) NecessitaLimpeza = " + defeitoLimpeza);
                    Console.WriteLine("(3) NecessitaTrocaDoCaboOuConector = " + defeitoCabo);
                    Console.WriteLine("(4) QuebradoOuInutilizado = " + defeitoQuebrado);
                    Console.WriteLine("(0) Continuar");

                    try
                    {
                        input = Int32.Parse(Console.ReadLine());

                        if (input == 0)
                        {
                            j = 1;
                            i = 0;
                            Mouse mouse = new Mouse(id[contador], defeitoEsfera, defeitoLimpeza, defeitoCabo, defeitoQuebrado);
                            mouseList.Add(mouse);
                        }

                        else if (input == 1)
                        {
                            if (defeitoEsfera == false) 
                            {
                                defeitoEsfera = true;
                            }
                            else
                            {
                                defeitoEsfera = false;
                            }
                        }

                        else if (input == 2)
                        {
                            if (defeitoLimpeza == false)
                            {
                                defeitoLimpeza = true;
                            }
                            else
                            {
                                defeitoLimpeza = false;
                            }
                        }

                        else if (input == 3)
                        {
                            if (defeitoCabo == false)
                            {
                                defeitoCabo = true;
                            }
                            else
                            {
                                defeitoCabo = false;
                            }
                        }

                        else if (input == 4)
                        {
                            if (defeitoQuebrado == false)
                            {
                                defeitoQuebrado = true;
                            }
                            else
                            {
                                defeitoQuebrado = false;
                            }
                        }

                        else
                        {
                            Console.WriteLine("O valor inserido é inválido. Aperte qualquer tecla para continuar.");
                            Console.ReadLine();
                        }

                    }
                    catch
                    {
                        Console.WriteLine("O valor inserido é inválido. Aperte qualquer tecla para continuar.");
                        Console.ReadLine();
                    }

                }

                contador++;
                defeitoEsfera = false;
                defeitoCabo = false;
                defeitoLimpeza = false;
                defeitoQuebrado = false;
            }

            relatorio:

            if(mouseList.Count > 0)
            {
                foreach (Mouse mousey in mouseList)
                {
                    if (mousey.Defeitos.Count == 0)
                    {
                        semDefeito++;
                    }
                    else if (mousey.Defeitos.Count == 1)
                    {
                        apenasUmDefeito++;
                    }
                    else
                    {

                    }
                }

                int totalSemDefeito = (semDefeito * 100) / mouseList.Count;
                int totalApenasUmDefeito = (apenasUmDefeito * 100) / mouseList.Count;

                Console.WriteLine("Relatório:");
                Console.WriteLine(".....................................................................");
                Console.WriteLine("Quantidade de mouses cadastrados:  " + mouseList.Count);
                Console.WriteLine("% de mouses sem defeitos:          " + totalSemDefeito + "%");
                Console.WriteLine("% de mouses com apenas um defeito: " + totalApenasUmDefeito + "%");

                Console.ReadLine();
            }

            else
            {
                Environment.Exit(0);
            }
        }
    }
}
