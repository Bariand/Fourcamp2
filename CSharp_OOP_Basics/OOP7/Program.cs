using System;

namespace OOP7
{
    internal class Program
    {

        //Crie um projeto no Visual Studio chamado Exercicio7 e implemente em C# a seguinte classe:


        //Conta Corrente
        //----------------------------------
        //~titular: string
        //~agenciaContaCorrente: int
        //~numeroContaCorrente: String
        //~saldo: double
        //----------------------------------
        //+depositar(valor: double) double
        //+sacar(valor: double): double
        //+exibirSaldo(): void


        //a) O método Depositar deve adicionar ao atributo saldo o valor passado como parâmetro e
        //retornar o saldo atualizado.
        //b) O método Sacar deve subtrair do atributo saldo o valor passado como parâmetro e retornar o
        //saldo atualizado.
        //c) O método ExibirSaldo deve exibir a seguinte mensagem no console: 
        //Olá<titular>, o seu saldo é: R$ <saldo>
        //Exemplo: Olá Edson, o seu saldo é: R$45.67

        

        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int input1 = 0;
            double valorDeposito = 0;

            ContaCorrente contaCorrente1 = new ContaCorrente();
            contaCorrente1.Titular = "Jaspion";

            while (i == 0)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("(1) Exibir Saldo");
                Console.WriteLine("(2) Depositar");
                Console.WriteLine("(3) Sacar");
                Console.WriteLine("(0) Sair");

                try
                {
                    input1 = Int32.Parse(Console.ReadLine());

                    if (input1 == 0)
                    {
                        Environment.Exit(0);
                    }

                    else if (input1 == 1)
                    {
                        contaCorrente1.ExibirSaldo();
                    }

                    else if (input1 == 2)
                    {
                        j = 0;

                        while(j == 0)
                        {
                            Console.WriteLine("Digite um valor, em Reais, para depositar: ");

                            try
                            {
                                valorDeposito = Double.Parse(Console.ReadLine());
                                j = 1;
                            }
                            catch
                            {
                                Console.WriteLine("Valor inserido não é válido. Utilize apenas números.");
                            }
                        }
                       
                        contaCorrente1.Depositar(valorDeposito);
                    }

                    else if (input1 == 3)
                    {
                        j = 0;

                        while (j == 0)
                        {
                            Console.WriteLine("Digite um valor, em Reais, para sacar: ");

                            try
                            {
                                valorDeposito = Double.Parse(Console.ReadLine());
                                j = 1;
                            }
                            catch
                            {
                                Console.WriteLine("Valor inserido não é válido. Utilize apenas números. Pressione qualquer tecla para continuar.");
                                Console.ReadLine();
                            }
                        }

                        contaCorrente1.Sacar(valorDeposito);
                    }

                    else
                    {
                        Console.WriteLine("O valor inserido não é válido. Pressione qualquer tecla para continuar.");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("O valor inserido não é válido. Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                }
            }
        }
    }
}
