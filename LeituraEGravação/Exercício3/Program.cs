using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Arquivos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3
            //Escreva um programa para ler um arquivo texto, onde cada linha contém um número do tipo
            //float, e ao final exibir para o usuário em qual linha foi encontrado o maior valor.

            int i = 0;

            var escritor = new StreamWriter("../../../Execício3.txt");

            escritor.WriteLine(3.9f);
            escritor.WriteLine(8.5f);
            escritor.WriteLine(7.9f);
            escritor.WriteLine(5.5f);
            escritor.WriteLine(3.2f);
            escritor.Close();

            var leitor = new StreamReader("../../../Execício3.txt");

            string[] linhas = leitor.ReadToEnd().Split("\n");

            List<float> fLinhas = new List<float>();

            for (i = 0; i < 5; i++)
            {
                fLinhas.Add(float.Parse(linhas[i]));
            }

            float maxValue = fLinhas.Max();

            Console.WriteLine(maxValue);
        }
    }
}
