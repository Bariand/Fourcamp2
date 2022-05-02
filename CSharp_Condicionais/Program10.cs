using System;
using System.Linq;

namespace CSharp_Condicionais10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             10). Uma instituição bancária utiliza um dígito verificador para validar o número da conta (com 3 dígitos) de 
            seus clientes. Faça um programa em C# que solicite o número da conta e calcule o dígito verificador. Os passos 
            para calcular o dígito verificador são: Ex: Número da conta = 235. 1) somar o número da conta com o seu inverso.
            Ex: 235 + 532 = 767 2) Multiplicar cada digito do número obtido no passo anterior pela sua ordem posicional e 
            somar esses resultados. O último digito do número obtido é o dígitoverificador. –Ex: 7 x 1 + 6 x 2 + 7 x 3 = 40
            (dígito verificador = 0).
             */

            int numero1 = 999;
            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("Digite o número da sua conta. Use exatamente três números: ");

                try
                {
                    numero1 = Int32.Parse(Console.ReadLine());

                    if (numero1 > 99 && numero1 <= 999)
                    {
                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("A senha inserida não é válida.");
                    }
                }
                catch
                {

                    Console.WriteLine("A senha inserida não é válida.");
                }
            }

            string stringNumero1 = numero1.ToString();

            //separa os dígitos individuais no íntegro de 3 dígitos

            int char0 = (int)Char.GetNumericValue(stringNumero1, 0);
            int char1 = (int)Char.GetNumericValue(stringNumero1, 1);
            int char2 = (int)Char.GetNumericValue(stringNumero1, 2);

            //transforma os dígitos Int em strings, para que possam ser concatenados

            string stringChar0 = char0.ToString();
            string stringChar1 = char1.ToString();
            string stringChar2 = char2.ToString();

            //obtendo o número invertido

            int numero1Invertido = Int32.Parse(stringChar2 + stringChar1 + stringChar0);

            //soma o número inicial mais o invertido e transforma em string

            int soma = numero1 + numero1Invertido;
            string stringSoma = soma.ToString();

            //separa os dígitos individuais no íntegro de 3 dígitos

            int charSoma0 = (int)Char.GetNumericValue(stringSoma, 0);
            int charSoma1 = (int)Char.GetNumericValue(stringSoma, 1);
            int charSoma2 = (int)Char.GetNumericValue(stringSoma, 2);

            Console.WriteLine("charSoma0 = " + charSoma0);
            Console.WriteLine("charSoma1 = " + charSoma1);
            Console.WriteLine("charSoma2 = " + charSoma2);
            Console.ReadLine();

            //Fórmula final

            if (soma > 999)
            {

                //Encontra mais um dígito, pois o número tem 4 dígitos

                int charSoma3 = (int)Char.GetNumericValue(stringSoma, 3);
                Console.WriteLine("charSoma3 = " + charSoma3);
                Console.ReadLine();

                string resultadoFinal = (charSoma0 * 1 + charSoma1 * 2 + charSoma2 * 3 + charSoma3 * 4).ToString();

                Console.WriteLine("string resultadoFinal =" + resultadoFinal);
                Console.ReadLine();

                int intResultadoFinal = Int32.Parse(resultadoFinal);

                if (intResultadoFinal > 9)
                {
                    int digitoVerificador = (int)Char.GetNumericValue(resultadoFinal, 1);
                    Console.WriteLine("dígito verificador =" + digitoVerificador);
                    Console.ReadLine();
                }

                else if (intResultadoFinal <= 9)
                {
                    int digitoVerificador = (int)Char.GetNumericValue(resultadoFinal, 0);
                    Console.WriteLine("dígito verificador =" + digitoVerificador);
                    Console.ReadLine();
                }

                else 
                {
                    Console.WriteLine("Algo de errado não está certo...");
                }
            }

            else if (soma <= 999)
            {
                string resultadoFinal = (charSoma0 * 1 + charSoma1 * 2 + charSoma2 * 3).ToString();

                Console.WriteLine("string resultadoFinal =" + resultadoFinal);
                Console.ReadLine();

                int intResultadoFinal = Int32.Parse(resultadoFinal);

                if (intResultadoFinal > 9)
                {
                    int digitoVerificador = (int)Char.GetNumericValue(resultadoFinal, 1);
                    Console.WriteLine("dígito verificador =" + digitoVerificador);
                    Console.ReadLine();
                }

                else if (intResultadoFinal <= 9)
                {
                    int digitoVerificador = (int)Char.GetNumericValue(resultadoFinal, 0);
                    Console.WriteLine("dígito verificador =" + digitoVerificador);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Algo de errado não está certo...");
                }
            }
        }
    }
}
