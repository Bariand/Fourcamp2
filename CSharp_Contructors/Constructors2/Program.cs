using System;

namespace Constructors2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placa = " ";
            string marca = " ";
            string modelo = " ";
            int ano = 0;
            string stringInput = " ";
            int input = 0;
            int i = 0;

            Console.WriteLine("Escreva a placa do carro:");

            placa = Console.ReadLine();

            Console.WriteLine("Agora escreva a marca:");

            marca = Console.ReadLine();

            Console.WriteLine("Escreva o modelo:");

            modelo = Console.ReadLine();

            while (i == 0) 
            {
                Console.WriteLine("Escreva o ano. Este deve ser um valor incluído entre 1900 e 2017:");

                try
                {
                    ano = Int32.Parse(Console.ReadLine());

                    if(ano >= 1900 && ano <= 2017)
                    {
                        i = 1;
                    }

                    else
                    {
                        Console.WriteLine("Valor inserido não é um ano válido. Pressione qualquer tecla para continuar.");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Valor inserido não é um ano válido. Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                }
            }

            Veiculo veiculo1 = new Veiculo(placa, marca, modelo, ano);

            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + ano);
            Console.ReadLine();
        }
    }
}
