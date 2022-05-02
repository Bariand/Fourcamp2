using System;

namespace CSharp_Exercícios1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7) Leia 2 valores de ponto flutuante de dupla precisão “v1” e “v2”, que 
                correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, 
                sabendo que a nota “v1” tem peso 3.5 e a nota “v2” tem peso 7.5 (A soma dos 
                pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com 
                uma casa decimal.
                Entrada
                O arquivo de entrada contém 2 valores com uma casa decimal cada um.
                Exemplos de Entrada Exemplos de Saída
                5.0
                7.1
                MEDIA = 6.43182
                0.0
                7.1
                MEDIA = 4.84091
                10.0
                10.0
                MEDIA = 10.00000
             */

            float v1 = 0f;
            float v2 = 0f;

            Console.WriteLine(" _______________________________________________________");
            Console.WriteLine("| Calculador de médias MEDIA: um programa mais ou menos |");
            Console.WriteLine(" -------------------------------------------------------");
            Console.ReadLine();

            int i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva a primeira média do aluno:");

                try
                {
                    v1 = float.Parse(Console.ReadLine());

                    if (v1 >= 0 && v1 <= 10)
                    {
                        i = 1;
                    }

                    else
                    {
                        Console.WriteLine("São apenas aceitos valores numéricos de 0 a 10.");
                    }

                }
                catch
                {
                    Console.WriteLine("São apenas aceitos valores numéricos de 0 a 10.");
                }
            }

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva a segunda média do aluno:");

                try
                {
                    v2 = float.Parse(Console.ReadLine());

                    if (v2 >= 0 && v2 <= 10)
                    {
                        i = 1;
                    }

                    else
                    {
                        Console.WriteLine("São apenas aceitos valores numéricos de 0 a 10.");
                    }
                }
                catch
                {
                    Console.WriteLine("São apenas aceitos valores numéricos de 0 a 10.");
                }
            }

            float media = (float)((v1 * 35 / 100) + (v2 * 75 / 100));

            string stringv1 = v1.ToString("0.0");
            string stringv2 = v2.ToString("0.0");

            Console.WriteLine("Nota 1 (peso 3,5): " + stringv1);
            Console.WriteLine("Nota 2 (peso 7,5): " + stringv2);
            Console.WriteLine("................................");
            Console.WriteLine("Média final: " + media);
            Console.ReadLine();
        }
    }
}
