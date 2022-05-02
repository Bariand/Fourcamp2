using System;

namespace CSharp_Exercícios1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            3) A fórmula para calcular a área de uma circunferência é: area = π . raio ^ 2
. 
            Considerando para este problema que π = 3.14159:
            - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando 
            por π.
            Entrada
            A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a 
            variável raio.
            Exemplos de Entrada Exemplos de Saída
            2.00 A = 12.5664
            100.64 A = 31819.3103
            150.00 A = 70685.7750

             */

            float raioCirculo = 0f;
            float pi = 3.14159f;

            int i = 0;

            Console.WriteLine("Vamos calcular a área de um círculo. Aperte qualquer tecla para continuar");
            Console.ReadLine();

            while (i == 0)
            {

                Console.WriteLine("Escreva, em cm, o raio do círculo: ");

                try
                {
                    raioCirculo = float.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor que você digitou não é considerado float. Tente novamente");
                }
            }

            float areaCirculo = (float)(pi * Math.Pow(raioCirculo, 2));

            Console.WriteLine("A área do círculo de raio " + raioCirculo + "cm é de " + areaCirculo + "cm.");
            Console.ReadLine();
        }
    }
}
