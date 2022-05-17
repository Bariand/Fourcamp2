using System;
using System.IO;

namespace Arquivos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2
            //Faça um programa em C# que gere um arquivo texto com N linhas e X colunas – ambas 
            //informadas pelo usuário, onde cada coluna é um valor inteiro randômico entre 0 e 1000.A
            //separação entre uma coluna e outra deve ser feita por uma tabulação(caractere tab).
            //Dica: pesquise o método Next da classe Random para gerar os números randômicos.

            int inputN = 0;
            int inputX = 0;
            int i = 0;
            int j = 0;

            Random randNum = new Random();

            Console.WriteLine("Insira o número de linhas: ");
            inputN = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de colunas: ");
            inputX = Int32.Parse(Console.ReadLine());

            var escritor = new StreamWriter("../../../Execício2.txt");

            for (i = 0; i < inputN; i++)
            {
                for (j = 0; j < inputX; j++)
                {
                    escritor.Write(randNum.Next(1000).ToString() + "    ");
                }
                escritor.Write("\n");
            }
            

            escritor.Close();
        }
    }
}
