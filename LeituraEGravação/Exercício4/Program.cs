using System;
using System.Collections.Generic;
using System.IO;

namespace Arquivos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 04
            //Crie um programa em C# para ler um arquivo texto, onde cada linha contém dois números
            //inteiros separados por vírgula. Este programa deve utilizar o arquivo de entrada citado acima
            //para gerar um arquivo com 3 campos, sendo o terceiro o valor da soma dos outros dois citados
            //anteriormente.

            List<int> intUnidade1 = new List<int>();
            List<int> intUnidade2 = new List<int>();
            List<int> soma = new List<int>();
            int i = 0;

            var writer = new StreamWriter("../../../Execício4.txt");

            writer.WriteLine("23, 876");
            writer.WriteLine("543, 59");
            writer.WriteLine("97, 745");
            writer.WriteLine("84, 486");
            writer.WriteLine("159, 33");
            writer.Close();

            var reader = new StreamReader("../../../Execício4.txt");

            string[] linha = reader.ReadToEnd().Split("\n");

            var writer2 = new StreamWriter("../../../Execício4_Res.txt");

            for (i = 0; i < 5; i++)
            {               
                string[] unidade = linha[i].Split(", ");
                intUnidade1.Add(Int32.Parse(unidade[0]));
                intUnidade2.Add(Int32.Parse(unidade[1]));
                soma.Add(intUnidade1[i] + intUnidade2[i]);

                writer2.WriteLine(intUnidade1[i] + " + " + intUnidade2[i] + " = " + soma[i]);
            }
            writer2.Close();
        }
    }
}
