using System;

namespace CSharp_Condicionais11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             11). Faça o teste de mesa para numero_1= 15 e numero_2= 6 resultado = ( ( numero_1 % 2 ) * 3 ) + ( 13 - 2 + numero_2 )
            Responda: 
            A). Qual o conteúdo da variável resultado quando termina o algoritmo?
            B). Analise o pseudocódigo e responda: o que mostrará na tela? 
            C). Reescrever o algoritmo utilizando a linguagem de programação C#.
             */

            Console.WriteLine("Digite um número inteiro: ");
            int numero_1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            int numero_2 = Int32.Parse(Console.ReadLine());

            int resultado = ((numero_1 % 2) * 3) + (13 - 2 + numero_2);

            if (resultado <= 0)
            {
                Console.WriteLine("Resultado menor ou igual a zero.");
            }

            else if (resultado > 0 && resultado <= 20)
            {
                Console.WriteLine("Resultado maior que zero ou igual a 20.");
            }

            else
            {
                Console.WriteLine("Resultado maior que 20.");
            }

            Console.ReadLine();

            /*
             Resposta das questões:
            A) 20
            B) "Resultado maior que zero ou igual a 20."
            C) Feito
             */
        }
    }
}
