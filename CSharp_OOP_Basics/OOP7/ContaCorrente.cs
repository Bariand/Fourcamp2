using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    internal class ContaCorrente
    {
        //~titular: string
        //~agenciaContaCorrente: int
        //~numeroContaCorrente: String
        //~saldo: double

        public string Titular { get; set; }
        public int AgenciaContaCorrente { get; set; }
        public string NumeroContaCorrente { get; set; }
        public double Saldo { get; set; }

        //+depositar(valor: double) double
        //a) O método Depositar deve adicionar ao atributo saldo o valor passado como parâmetro e
        //retornar o saldo atualizado.

        public double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }

        //+sacar(valor: double): double
        //b) O método Sacar deve subtrair do atributo saldo o valor passado como parâmetro e retornar o
        //saldo atualizado.

        public double Sacar(double valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        //+exibirSaldo(): void
        //c) O método ExibirSaldo deve exibir a seguinte mensagem no console: 
        //Olá<titular>, o seu saldo é: R$ <saldo>
        //Exemplo: Olá Edson, o seu saldo é: R$45.67

        public void ExibirSaldo()
        {
            Console.WriteLine("Olá " + Titular + ". O seu saldo é: R$ " + Saldo.ToString("0.00"));
        }
    }
}
