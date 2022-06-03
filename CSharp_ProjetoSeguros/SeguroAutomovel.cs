using System;

namespace CSharp_ProjetoSeguros
{
    internal class SeguroAutomovel : Seguro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }

        public SeguroAutomovel(double valor, DateTime data, string modelo, string marca, int ano, int quilometragem) : base(valor, data)
        {
            Valor = valor;
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Quilometragem = quilometragem;
            Data = data;
        }

        public override string Cabecalho()
        {
            string stringCabecalho = (base.Cabecalho() + "Automóvel---------");
            return stringCabecalho;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Data de contratação: " + Data);
            Console.WriteLine("Marca do automóvel: " + Marca);
            Console.WriteLine("Modelo do automóvel: " + Modelo);
            Console.WriteLine("Ano do automóvel: " + Ano);
            Console.WriteLine("Quilometragem do automóvel: " + Quilometragem + " Km");
            Console.WriteLine("Valor do automóvel: " + Valor.ToString("C"));
            Console.WriteLine("----------------------------------");
        }
    }
}
