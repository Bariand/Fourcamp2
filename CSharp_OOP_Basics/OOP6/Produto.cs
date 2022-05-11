using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public double DescontoProduto { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Insira o nome do produto: ");
            NomeProduto = Console.ReadLine();
            
            int i = 0;

            while(i == 0)
            {
                Console.WriteLine("Insira o preço do produto, em Reais: ");
                try
                {
                    PrecoProduto = Double.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor inserido é inválido.");
                    Console.ReadLine();
                }
                
            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Insira a quantidade do produto em estoque, em unidades: ");
                try
                {
                    QuantidadeProduto = Int32.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor inserido é inválido.");
                    Console.ReadLine();
                }

            }

            i = 0;

            while (i == 0)
            {
                Console.WriteLine("Insira o desconto aplicado no produto, em porcentagem. Exemplo: 20 é igual a 20% de desconto: ");
                try
                {
                    DescontoProduto = Double.Parse(Console.ReadLine());
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("O valor inserido é inválido.");
                    Console.ReadLine();
                }
            }             
        }
    }
}
