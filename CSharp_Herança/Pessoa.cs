using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Herança1
{
    public class Pessoa
    {

        //c.Adicione um construtor na classe Pessoa de forma que a propriedade Nome possa ser
        //inicializado por ele.Fique livre para fazer todas as alterações nas classes do projeto que
        //sejam necessárias para a compilação das classes.

        public int Id { get; set; }
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual void ExibirNomeFormatado()
        {
            Nome = Nome.ToUpper();
        }
    }
}
