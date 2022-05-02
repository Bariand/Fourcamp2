using System;

namespace CSharp_Loops3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3). Elabore um programa em C# que mostre na tela somente os números pares entre 100 e
                 200. Incluindo-os.
             */

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
