using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_ColeçõesdeDados6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Validações:
              6). Faça um programa em C# que solicite ao usuário 15 números inteiros. 
              Guardar os números em lista: 
              A primeira lista deve conter os números positivos e pares. 
              A segunda lista deve conter os números positivos e ímpares. 
              A terceira lista deve conter os números negativos. 
              a) Não aceitar número igual a 0 (zero). 
              b) Não aceitar números repetidos. 
              c) O usuário precisa digitar obrigatoriamente 15 números válidos conforme validações a e b. 
              Mostrar na tela: 
              - As três listas resultantes 
              - O maior e o menor número digitado pelo usuário 
              Exemplo: 
              Lista 1 – números positivos e pares: 
              4 8 2 12 44 6 10
              Lista 2 – números positivos e ímpares: 
              5 1 17 13 9
              Lista 3 – números negativos: 
              -7 -9 -6
              Maior número digitado: 44 
              Menor número digitado: -9*/

            int input = 0;
            List<int> numerosPositivosPares = new List<int>();
            List<int> numerosPositivosImpares = new List<int>();
            List<int> numerosNegativos = new List<int>();
            List<int> inputList = new List<int>();

            Console.WriteLine("Insira 15 números distintos, inteiros e diferentes de zero: ");
            Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "º número: ");
                try
                {
                    input = Int32.Parse(Console.ReadLine());

                    //Input não pode ser zero e não pode ter sido digitado antes

                    if (inputList.Contains(input))
                    {
                        Console.WriteLine("O valor inserido já existe. Tente outro valor.");
                        i -= 1;
                    }

                    else if (input != 0)
                    {

                        //Três listas: par e positivo, ímpar e positivo e negativo. "Else" serve para eu poder pegar erro eventual.

                        if (input > 0 && input % 2 == 0)
                        {
                            numerosPositivosPares.Add(input);
                            inputList.Add(input);
                        }

                        else if (input > 0 && input % 2 == 1)
                        {
                            numerosPositivosImpares.Add(input);
                            inputList.Add(input);
                        }

                        else if (input < 0)
                        {
                            numerosNegativos.Add(input);
                            inputList.Add(input);
                        }

                        else
                        {
                            Console.WriteLine("Algo de errado não está certo...");
                        }
                    }

                    else
                    {
                        Console.WriteLine("O valor inserido deve ser inteiro e não pode ser igual a zero.");
                        i -= 1;
                    }
                   
                }
                catch
                {
                    Console.WriteLine("O número inserido não é um número inteiro.");
                }

            }

            Console.WriteLine("Lista de números positivos e pares: ");

            foreach (int a in numerosPositivosPares)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Lista de números positivos e ímpares: ");

            foreach (int a in numerosPositivosImpares)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Lista de números negativos: ");

            foreach (int a in numerosNegativos)
            {
                Console.WriteLine(a);
            }

            int max = inputList.Max();

            Console.WriteLine("Maior número digitado: " + inputList.Max());
            Console.WriteLine("Menor número digitado: " + inputList.Min());

            Console.ReadLine();
        }

    }

}
