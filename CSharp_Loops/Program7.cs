using System;

namespace CSharp_Loops7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             7). Faça um programa em C# que gere números inteiros aleatórios entre 100 e 110. Calcular a 
                soma dos números gerados até que o número n1 (valor informado pelo usuário) seja gerado.
                Dica:
                Como gerar números aleatórios:
                Random randNum = new Random();
                int numeroAleatorio = randNum.Next(100, 110);

             */
            int i = 0;
            int n1 = 0;
            //int randNum = 0;

            while (i == 0)
            {
                Console.WriteLine("Insira um número inteiro maior ou igual a 1000: ");

                try
                {
                    n1 = Int32.Parse(Console.ReadLine());

                    if (n1 > 999) 
                    {
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("O valor inserido não é válido.");
                    }
                }
                catch
                {
                    Console.WriteLine("O valor inserido não é válido.");
                }
            }

            int numeroAleatorio = 0;
            Random randNum = new Random();

            for (i = 0; numeroAleatorio <= n1; i++)
            {
                numeroAleatorio += randNum.Next(100, 110);
            }

            Console.WriteLine("A soma dos números gerados até chegar ao valor n1 foi de: " + numeroAleatorio);
            Console.ReadLine();
        }
    }
}
