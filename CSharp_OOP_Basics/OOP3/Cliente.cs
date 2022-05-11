using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public int IdadeCliente { get; set; }
        public char SexoCliente { get; set; }
        public int NumeroCartaoCliente { get; set; }
        public double SaldoCliente { get; set; }
        public int PontosFidelidadeCliente { get; set; }
        public char FisicaOuJuridicaCliente { get; set; }

        public bool CadastroCliente { get; set; }

        public List<Livro> carrinho = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            carrinho.Add(livro);

            //seria possível fazer uma lógica aqui para alterar a variável "recebimento do livro". Decidi criar um método,
            //já que não era para fazer a lógica mas sim, identificar classes

        }

        public void RemoverLivro(Livro livro)
        {
            carrinho.Remove(livro);       
        }

        public void Pagar()
        {
            //Aqui deve ser colocada a lógica para direcionar o cliente para o método "CadastrarCliente()" caso ele não tenha.
            //Um if-else resolve este problema (não ter cadastro seria algo como "cadastro == null" caso este não esteja completo)
            //Aqui deve também estar um "if-else" para o caso de ser pessoa física ou jurídica, sendo no segundo caso pedidos os
            //dados extras
        }

        public void RecebimentoLivroEMail(Livro livro)
        {
            livro.RecebimentoLivro = 'e';
        }

        public void RecebimentoLivroDownload(Livro livro)
        {
            livro.RecebimentoLivro = 'd';
        }

        public void CadastrarCliente()
        {
            //Este método deve pedir todos os dados do cliente e armazenálos nas respectivas variáveis do objeto
        }
    }
}
