using System;

namespace CSharp_Loop9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string input;
            int numeroSoma1 = 0;
            int numeroSoma2 = 0;
            int numeroRaiz = 0;

            while (i == 0)
            {

                Console.Clear();
                i = 0;
                j = 0;

                Console.WriteLine(" ________________________________________________________");
                Console.WriteLine("|Ultra Calc Turbo 14.2                                   |");
                Console.WriteLine(" --------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("(1): Soma de dois números");
                Console.WriteLine("(2): Raiz quadrada de um número");
                Console.WriteLine("(3): Sair");

                input = Console.ReadLine();
                Console.WriteLine(" ");

                if (input == "1")
                {
                    while (j == 0)
                    {
                        Console.WriteLine("Insira um número inteiro: ");

                        try
                        {
                            numeroSoma1 = Int32.Parse(Console.ReadLine());
                            j = 1;
                        }
                        catch
                        {
                            Console.WriteLine("O número inserido não é válido.");
                        }
                    }

                    j = 0;

                    while (j == 0)
                    {
                        Console.WriteLine("Insira um outro número inteiro: ");

                        try
                        {
                            numeroSoma2 = Int32.Parse(Console.ReadLine());
                            j = 1;
                        }
                        catch
                        {
                            Console.WriteLine("O número inserido não é válido.");
                        }
                    }

                    Console.WriteLine(numeroSoma1 + " + " + numeroSoma2 + " = " + (numeroSoma1 + numeroSoma2));
                    Console.ReadLine();
                }

                if (input == "2")
                {
                    while (j == 0)
                    {
                        Console.WriteLine("Insira um número inteiro: ");

                        try
                        {
                            numeroRaiz = Int32.Parse(Console.ReadLine());
                            j = 1;
                        }
                        catch
                        {
                            Console.WriteLine("O número inserido não é válido.");
                        }
                    }

                    Console.WriteLine("Raiz quadrada de " + numeroRaiz + " = " + (Math.Sqrt(numeroRaiz)));
                    Console.ReadLine();
                }

                else if (input == "3")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
