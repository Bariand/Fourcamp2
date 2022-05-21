using System;

namespace SSharp_ComplementoOOI1
{
    internal class Program
    {
        public static void IAmError()
        {
            Console.WriteLine("O valor inserido não é válido. Pressione qualquer tecla para continuar");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Exercício 01 - Implemente em C# o seguinte Diagrama de Classes.
            //Exercício 01.1
            //A partir das informações listadas abaixo, implemente corretamente o método CalcularArea nas
            //classes Quadrado, Circulo e Triangulo:
            //A área do quadrado é calculada através da fórmula: Área = lado * lado
            //A área do triangulo é calculada através da fórmula: Área = (base * altura) / 2
            //A área do círculo é calculada através da fórmula: Área = pi * (raio * raio)
            //Exercício 01.2
            //No arquivos Program:
            //O usuário ao executar o programa escolha qual forma(Quadrado, Triângulo ou Círculo) deseja
            //calcular a área, em seguida, o sistema deve solicitar a(s) medida(s) da forma escolhida e exibir
            //no console o nome e a área da forma, no seguinte formato: 
            //A área do ...é: ....Exemplo: A área do Quadrado é: 4

            int i = 0;
            int j = 0;
            int input1 = 0;
            double input2 = 0;
            double input3 = 0; 

            while(i == 0)
            {
                Console.WriteLine("Escolha a forma geométrica que deseja ter a área calculada: ");
                Console.WriteLine("(1) Triângulo ");
                Console.WriteLine("(2) Quadrado ");
                Console.WriteLine("(3) Círculo ");

                try
                {
                    input1 = Int32.Parse(Console.ReadLine());
                    i = 1;

                    switch (input1)
                    {
                        case 1:
                            while(j == 0)
                            {
                                Console.WriteLine("Insira o valor da BASE do triângulo: ");
                                try
                                {
                                    input2 = double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    IAmError();
                                }
                            }

                            j = 0;

                            while (j == 0)
                            {
                                Console.WriteLine("Insira o valor da ALTURA do triângulo: ");
                                try
                                {
                                    input3 = double.Parse(Console.ReadLine());
                                    j = 1;
                                   
                                }
                                catch
                                {
                                    IAmError();
                                }
                            }

                            Triangulo triangulo = new Triangulo(input2, input3);

                            Console.WriteLine("A área do triângulo de base " + triangulo.Base + " e altura " + triangulo.Altura + " = " + triangulo.CalcularArea());
                            break;

                        case 2:
                            while (j == 0)
                            {
                                Console.WriteLine("Insira o valor do LADO do quadrado: ");
                                try
                                {
                                    input2 = double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    IAmError();
                                }
                            }

                            j = 0;

                            Quadrado quadrado = new Quadrado(input2);

                            Console.WriteLine("A área do quadrado de lado " + quadrado.Lado + " = " + quadrado.CalcularArea());
                            break;

                        case 3:
                            while (j == 0)
                            {
                                Console.WriteLine("Insira o valor do RAIO do círculo: ");
                                try
                                {
                                    input2 = double.Parse(Console.ReadLine());
                                    j = 1;
                                }
                                catch
                                {
                                    IAmError();
                                }
                            }

                            Circulo circulo = new Circulo(input2);

                            Console.WriteLine("A área do círculo de raio " + circulo.Raio + " = " + circulo.CalcularArea());
                            break;
                    }                            
                }
                catch
                {
                    IAmError();
                }
            }
        }
    }
}
