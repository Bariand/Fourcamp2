using System;
using System.Collections.Generic;

namespace CSharp_ProjetoSeguros
{
    internal class Program
    {
        static void Main()
        {
            int i = 0;
            int j = 0;
            int input;
            double valor = 0;
            string modelo;
            string marca;
            int ano = 0;
            int quilometragem = 0;
            double area = 0;
            string cidade;
            DateTime data;

            List<SeguroResidencial> segurosResidenciais = new List<SeguroResidencial>();
            List<SeguroCelular> segurosCelulares = new List<SeguroCelular>();
            List<SeguroAutomovel> segurosAutomoveis = new List<SeguroAutomovel>();

            while (i == 0)
            {
                Console.WriteLine("Escolha o tipo de seguro para avaliação:");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("1 - Celular");
                Console.WriteLine("2 - Residencial");
                Console.WriteLine("3 - Automóvel");
                Console.WriteLine("4 - Meus Seguros");
                Console.WriteLine("5 - Sair");

                try
                {
                    input = Int32.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:

                            Console.WriteLine("Insira o modelo do telefone celular: ");
                            modelo = Console.ReadLine();
                            Console.WriteLine("Insira a marca do telefone celular: ");
                            marca = Console.ReadLine();

                            while(j == 0)
                            {
                                Console.WriteLine("Insira o valor do telefone celular: ");

                                try
                                {
                                    valor = Double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            data = DateTime.Now;

                            SeguroCelular seguroCelular = new SeguroCelular(valor, data, modelo, marca);
                            segurosCelulares.Add(seguroCelular);

                            Console.WriteLine(" ");
                            Console.WriteLine("Seguro do telefone celular adicionado com sucesso!");
                            Console.WriteLine(" ");
                            break;

                        case 2:

                            Console.WriteLine("Insira a cidade da residência: ");
                            cidade = Console.ReadLine();

                            while (j == 0)
                            {
                                Console.WriteLine("Insira a área em metros quadrados da residência: ");

                                try
                                {
                                    area = Double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            while (j == 0)
                            {
                                Console.WriteLine("Insira o valor da residência: ");

                                try
                                {
                                    valor = Double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            data = DateTime.Now;

                            SeguroResidencial seguroResidencial = new SeguroResidencial(valor, data, cidade, area);
                            segurosResidenciais.Add(seguroResidencial);

                            Console.WriteLine(" ");
                            Console.WriteLine("Seguro residencial adicionado com sucesso!");
                            Console.WriteLine(" ");
                            break;

                        case 3:

                            Console.WriteLine("Insira o modelo do automovel: ");
                            modelo = Console.ReadLine();
                            Console.WriteLine("Insira a marca do automovel: ");
                            marca = Console.ReadLine();

                            while (j == 0)
                            {
                                Console.WriteLine("Insira o ano do automóvel: ");

                                try
                                {
                                    ano = Int32.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            while (j == 0)
                            {
                                Console.WriteLine("Insira a quilometragem do automóvel: ");

                                try
                                {
                                    quilometragem = Int32.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            while (j == 0)
                            {
                                Console.WriteLine("Insira o valor do automóvel: ");

                                try
                                {
                                    valor = Double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    MsgErro.Erro1();
                                }
                            }

                            j = 0;

                            data = DateTime.Now;

                            SeguroAutomovel seguroAutomovel = new SeguroAutomovel(valor, data, modelo, marca, ano, quilometragem);
                            segurosAutomoveis.Add(seguroAutomovel);

                            Console.WriteLine(" ");
                            Console.WriteLine("Seguro veicular adicionado com sucesso!");
                            Console.WriteLine(" ");
                            break;

                        case 4:

                            foreach (SeguroCelular segCel in segurosCelulares)
                            {
                                Console.WriteLine(segCel.Cabecalho());
                                segCel.ExibirInformacoes();
                            }
                            foreach (SeguroResidencial segRes in segurosResidenciais)
                            {
                                Console.WriteLine(segRes.Cabecalho());
                                segRes.ExibirInformacoes();
                            }
                            foreach (SeguroAutomovel segAut in segurosAutomoveis)
                            {
                                Console.WriteLine(segAut.Cabecalho());
                                segAut.ExibirInformacoes();
                            }

                            Console.ReadLine();
                            break;

                        case 5:

                            Console.WriteLine(" ");
                            Console.WriteLine("Aplicação terminada.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;

                        default:

                           MsgErro.Erro2();
                            break;
                    }
                }
                catch
                {
                    MsgErro.Erro2();
                }
            }
        }
    }
}
