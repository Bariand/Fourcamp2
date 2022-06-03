using System;

namespace CSharp_ProjetoSeguros
{
    internal class SeguroResidencial : Seguro
    {
        public string Cidade { get; set; }
        public double Area { get; set; }

        public SeguroResidencial(double valor, DateTime data, string cidade, double area) : base(valor, data)
        {
            Valor = valor;
            Area = area;
            Cidade = cidade;
            Data = data;
        }

        public override string Cabecalho()
        {
            string stringCabecalho = (base.Cabecalho() + "Residencial--------");
            return stringCabecalho;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Data de contratação: " + Data);
            Console.WriteLine("Cidade da residência: " + Cidade);
            Console.WriteLine("Área da residência: " + Area + " m³");
            Console.WriteLine("Valor da residência: " + Valor.ToString("C"));
            Console.WriteLine("----------------------------------");
        }
    }
}
