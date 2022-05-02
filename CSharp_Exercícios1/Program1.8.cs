using System;

namespace CSharp_Exercícios1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             8) Leia 3 valores, no caso, variáveis “v1”, “v2” e “v3”, que são as três notas de um 
            aluno. A seguir, calcule a média do aluno, sabendo que a nota “v1” tem peso 2, a 
            nota “v2” tem peso 3 e a nota “v3” tem peso 5. Considere que cada nota pode ir 
            de 0 até 10.0, sempre com uma casa decimal.
            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão 
            (double).
            Exemplos de Entrada Exemplos de Saída
            5.0
            6.0
            7.0
            MEDIA = 6.3
            5.0
            10.0
            10.0
            MEDIA = 9.0
            10.0
            10.0
            5.0
            MEDIA = 7.
             */

            double v1 = 0;
            double v2 = 0;
            double v3 = 0;

            Console.WriteLine(" ________________________________________________");
            Console.WriteLine("| Calculador de médias MEDIA 2: 50% mais médias! |");
            Console.WriteLine(" ------------------------------------------------");
            Console.ReadLine();

            int i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva a primeira média do aluno:");

                try
                {
                    v1 = double.Parse(Console.ReadLine());

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
                    v2 = double.Parse(Console.ReadLine());

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

            i = 0;

            while (i == 0)
            {

                Console.WriteLine("Escreva a terceira média do aluno:");

                try
                {
                    v3 = double.Parse(Console.ReadLine());

                    if (v3 >= 0 && v3 <= 10)
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

            double media = (double)((v1 * 20 / 100) + (v2 * 30 / 100) + (v3 * 50 / 100));
            string stringMedia = media.ToString("0.0");

            string stringv1 = v1.ToString("0.0");
            string stringv2 = v2.ToString("0.0");
            string stringv3 = v3.ToString("0.0");

            Console.WriteLine("Nota 1 (peso 2,0): " + stringv1);
            Console.WriteLine("Nota 2 (peso 3,0): " + stringv2);
            Console.WriteLine("Nota 3 (peso 5,0): " + stringv3);
            Console.WriteLine(".................................");
            Console.WriteLine("Média final: " + stringMedia);
            Console.ReadLine();
        }
    }
}
