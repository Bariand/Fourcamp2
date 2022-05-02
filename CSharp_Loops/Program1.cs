using System;

namespace CSharp_Loops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1). Faça um programa em C# que mostre na tela a tabuada do 5.

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("5 * {0} = {1}", i, (i * 5));
            }

            Console.ReadLine();
        }
    }
}
