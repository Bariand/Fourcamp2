using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Arquivos5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler um arquivo texto que possui a seguinte estrutura:
            //a) A primeira linha contém um número inteiro, este número indica o total de registros no
            //arquivo.
            //b) Os campos dos registros são separados por vírgula, sendo o primeiro um caractere,
            //seguindo de um valor inteiro e um valor real.
            //c) Após ler o arquivo o programa deverá exibir a somatória do segundo campo.

            int i = 0;
            int j = 0;
            List<int> segundoCampo = new List<int>();
            int soma = 0;
            var writer1 = new StreamWriter("../../../Execício5.txt");            

            writer1.WriteLine("5");
            writer1.WriteLine("A,30,12.6");
            writer1.WriteLine("T,4,8.88804");
            writer1.WriteLine("C,555,0.0001");
            writer1.WriteLine("G,1000,1024.7851");
            writer1.WriteLine("C,-45,-985.0");
            writer1.Close();

            var reader1 = new StreamReader("../../../Execício5.txt");

            string[] linha = reader1.ReadToEnd().Split("\n");

            for (i = 0; i < 6; i++)
            {
                string[] unidade = linha[i].Split(",");

                if(unidade.Count() > 2 && i > 0)
                {
                    segundoCampo.Add(Int32.Parse(unidade[1]));
                    soma += segundoCampo[j];
                    j++;
                }                
            }
            reader1.Close();

            Console.WriteLine(soma);
        }
    }
}
