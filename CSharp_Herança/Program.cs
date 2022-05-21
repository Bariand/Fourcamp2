using System;

namespace CSharp_Herança1
{
    internal class Program
    {
        //Exercício 01- Implemente as classes

        //Exercício 02
        //Faça as seguintes alterações nas classes criadas anteriormente:
        //a.Implemente o método ExibirNomeFormatado da classe Pessoa de forma que ele exiba a propriedade
        //Nome em maiúsculo.
        //b.Sobrescreva o método ExibirNomeFormatado na classe Cliente de forma que ele exiba o
        //Titulo e o Nome do cliente, em maiúsculo e no seguinte formato: <TITULO> - <NOME>
        //c.Adicione um construtor na classe Pessoa de forma que a propriedade Nome possa ser
        //inicializado por ele.Fique livre para fazer todas as alterações nas classes do projeto que
        //sejam necessárias para a compilação das classes.

        //Exercício 03
        //a) Escreva um programa para cadastrar um Cliente.
        //
        //b)Instancie o objeto do tipo Cliente e preencha as propriedades deste objeto com dados vindos do
        //usuário e depois evoque o método ExibirNomeFormatado da classe Cliente.
        static void Main(string[] args)
        {
            string titulo = " ";
            string nome = " ";
            int id = 0;
            int i = 0;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();  

            while(i == 0)
            {
                Console.WriteLine("Insira sua id: ");

                try
                {
                    id = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor inserido deve conter apenas números. Aperte qualquer tecla para continuar");
                    Console.ReadLine();
                }

            }


            Console.WriteLine("Insira seu título: ");
            titulo = Console.ReadLine();

            Cliente cliente1 = new Cliente(titulo, nome);

            cliente1.ExibirNomeFormatado();
        }
    }
}
