using System;

namespace CSharp_Condicionais9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             9). Uma companhia aérea define os preços de suas passagens a partir da informação do 
                destino bem como do número de passagens (se é apenas ida ou se inclui também a volta). 
                Faça um programa em C# que solicite o destino bem como se o cliente deseja somente ida ou 
                ida e volta. Informe o preço de acordo com a tabela abaixo (PS: a empresa não trabalha nos 
                trechos sul e sudeste).
                Região Ida Ida e volta
                Norte R$280 R$400
                Nordeste R$380 R$628
                Centro-Oeste R$620 R$1100
             */

            string regiaoViajem = null;
            string passagemIdaEVolta = null;

            int i = 0;

            Console.WriteLine( "______________________________________________________________");
            Console.WriteLine("|JUMENTO VOADOR AVIAÇÂO - Balançar balança, mas cair não cai!* |");
            Console.WriteLine(" --------------------------------------------------------------");
            Console.ReadLine();

            Console.WriteLine("Jumento Aviação - tabela de preços:                 ");
            Console.WriteLine(" __________________________________________________ ");
            Console.WriteLine("| Região         |   Somente Ida   |   Ida e Volta |");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("| Norte          |   R$ 280,00     |   R$ 400,00   |");
            Console.WriteLine("| Nordeste       |   R$ 380,00     |   R$ 628,00   |");
            Console.WriteLine("| Centro-Oeste   |   R$ 620,00     |   R$ 1100,00  |");
            Console.WriteLine(" -------------------------------------------------- ");
            Console.ReadLine();

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Escreva para qual região você planeja viajar:");
                Console.WriteLine("Regiões válidas: Norte, Nordeste ou Centro-Oeste");


                try
                {
                    regiaoViajem = Console.ReadLine();
                    regiaoViajem = regiaoViajem.ToLower();

                    if (regiaoViajem == "norte" || regiaoViajem == "nordeste" || regiaoViajem == "centro-oeste" ||
                        regiaoViajem == "região norte" || regiaoViajem == "região nordeste" || regiaoViajem == "região centro-oeste")
                    {
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("A região que você digitou não é válida.");
                    }
                }
                catch
                {

                    Console.WriteLine("A região que você digitou não é válida.");
                }
            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Você deseja passagem apenas de Ida ou de Ida e Volta?");
                Console.WriteLine("Digite IDA para apenas ida ou IDA E VOLTA para passagens de ida e volta");

                try
                {
                    passagemIdaEVolta = Console.ReadLine();
                    passagemIdaEVolta = passagemIdaEVolta.ToLower();

                    if (passagemIdaEVolta == "ida" || passagemIdaEVolta == "ida e volta")
                    {
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("O tipo de passagem que você digitou não é válido.");
                    }
                }
                catch
                {

                    Console.WriteLine("O tipo de passagem que você digitou não é válido.");
                }
            }

            if ((regiaoViajem == "norte" && passagemIdaEVolta == "ida") || (regiaoViajem == "região norte" && passagemIdaEVolta == "ida"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 280,00");
                Console.ReadLine();
            }

            else if ((regiaoViajem == "norte" && passagemIdaEVolta == "ida e volta") || (regiaoViajem == "região norte" && passagemIdaEVolta == "ida e volta"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 400,00");
                Console.ReadLine();
            }

            else if ((regiaoViajem == "nordeste" && passagemIdaEVolta == "ida") || (regiaoViajem == "região nordeste" && passagemIdaEVolta == "ida"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 380,00");
                Console.ReadLine();
            }

            else if ((regiaoViajem == "nordeste" && passagemIdaEVolta == "ida e volta") || (regiaoViajem == "região nordeste" && passagemIdaEVolta == "ida e volta"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 628,00");
                Console.ReadLine();
            }

            else if ((regiaoViajem == "centro-oeste" && passagemIdaEVolta == "ida") || (regiaoViajem == "região centro-oeste" && passagemIdaEVolta == "ida"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 620,00");
                Console.ReadLine();
            }

            else if ((regiaoViajem == "centro-oeste" && passagemIdaEVolta == "ida e volta") || (regiaoViajem == "região centro-oeste" && passagemIdaEVolta == "ida e volta"))
            {
                Console.WriteLine("O preço da sua passagem é de R$ 1100,00");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Algo errado não está certo...");
            }
        }
    }
}
