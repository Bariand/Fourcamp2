using System;

namespace SSharp_Exercícios1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1) Leia 2 valores inteiros e armazene-os nas variáveis “valor1” e “valor2”. Efetue a
            soma de “valor1” e “valor2” atribuindo o seu resultado na variável “resultado”.
            Imprima “resultado” conforme exemplo apresentado abaixo.
            Exemplos de Entrada Exemplos de Saída
            10
            9
            Resultado = 19

            - 10
            4
            Resultado = -6
            
            15
            - 7
            Resultado = 8
            */

            int valor1 = 0;
            int valor2 = 0;

            int i = 0;

            while (i == 0) 
            {

                Console.WriteLine("escreva um valor para a variável valor1:");

                try
                {
                    valor1 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("escreva um valor para a variável valor2:");

                try
                {
                    valor2 = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é um Integer. Tente novamente");
                }
            }

            int soma = valor1 + valor2;

            Console.WriteLine("O resultado da sua soma é: " + soma);
            Console.ReadLine();
        }
    }
}
