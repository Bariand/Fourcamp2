using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Arquivos1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Exercício 1
            //Crie um programa em C# para ler um arquivo texto e escrever apenas os caracteres 
            //alfabéticos(letras). Números e caracteres especiais devem ser desconsiderados.
            //Dica: pesquise sobre a tabela ASCII.

            //define escritor de arquivo externo
            var escritor = new StreamWriter("../../../Execício1.txt");

            escritor.WriteLine("a;b;c;d;e;f;g;h;i;j;k;l;m;n;1;o;p;q;r;s;t;2;u;v;w;x;y;3;z");

            escritor.Close();

            //cria um leitor de arquivo externo
            var leitor = new StreamReader("../../../Execício1.txt");
            
            //cria os arrays com os dados do arquivo
            string[] linhas = leitor.ReadToEnd().Split("\n");
            string[] linhaSeparada = linhas[0].Split(";");

            for(int i = 0; i < 29; i++)
            {
                if(Regex.IsMatch(linhaSeparada[i], @"^[a-zA-Z]+$")) //Testa se valores estão entre a-z e A-Z
                {
                    Console.WriteLine(linhaSeparada[i]);
                }
                else
                {

                }
            }

            leitor.Close(); //Fecha o arquivo externo
        }
    }
}
