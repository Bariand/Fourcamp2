using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Herança1
{
    public class Cliente : Pessoa
    {
        //b.Sobrescreva o método ExibirNomeFormatado na classe Cliente de forma que ele exiba o
        //Titulo e o Nome do cliente, em maiúsculo e no seguinte formato: <TITULO> - <NOME>
        public string Titulo { get; set; }

        public Cliente(string nome, string titulo) : base(nome)
        {
            Nome = nome;
            Titulo = titulo;
        }

        public override void ExibirNomeFormatado()
        {
            Nome = Nome.ToUpper();
            Titulo = Titulo.ToUpper();

            Console.WriteLine(" ");
            Console.WriteLine(Nome + " - " + Titulo);
            Console.ReadLine();
        }
    }
}
