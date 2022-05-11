using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Livro
    {
        public string NomeLivro { get; set; }
        public string GeneroLivro { get; set; }
        public double PrecoLivro { get; set; }
        public bool PromocaoLivro { get; set; }
        public double DescontoLivro { get; set; }
        public char RecebimentoLivro { get; set; } //Variável que indica se livro será recebido por e-mail ou download
    }
}
