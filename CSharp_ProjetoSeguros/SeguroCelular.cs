using System;

namespace CSharp_ProjetoSeguros
{
    internal class SeguroCelular : Seguro
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public SeguroCelular(double valor, DateTime data, string modelo, string marca) : base(valor, data)
        {
            Valor = valor;
            Modelo = modelo;
            Marca = marca;
            Data = data;
        }

        public override string Cabecalho()
        {
            string stringCabecalho = (base.Cabecalho() + "Celular----------");
            return stringCabecalho;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Data da contratação: " + Data);
            Console.WriteLine("Modelo do celular: " + Modelo);
            Console.WriteLine("Marca do celular: " + Marca);
            Console.WriteLine("Valor do celular: " + Valor.ToString("C"));
            Console.WriteLine("----------------------------------");
        }
    }
}
