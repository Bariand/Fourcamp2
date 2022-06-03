using System;

namespace CSharp_ProjetoSeguros
{
    internal abstract class Seguro
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public Seguro(double valor, DateTime data)
        {
            Valor = valor;
            Data = data;
        }

        public virtual string Cabecalho()
        {
            return "----------Seguro ";
        }

        public abstract void ExibirInformacoes();
    }
}
