using System;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie as classes desenhadas por você no exercício de Sistema de e - Commerce para venda de
            //livros digitais(e - book)
            //..........................................................................................................
            //Exercício Abstração e Modelagem
            //A partir do caso exibido a seguir:
            //– Realizar a abstração para encontrar as classes
            //– Montar as classes com os atributos
            //» Definir o tipo de cada atributo
            //– String - para texto
            //– int -para número inteiro
            //– double -para número real
            //– Date - para data
            //– boolean – para verdadeiro/ falso
            //– Montar as classes com operações
            //Prof.Douglas Cabral<douglas.cabral @fiap.com.br> https://www.linkedin.com/in/douglascabral/
            //Exercício Abstração e Modelagem
            //Caso: Sistema de e - Commerce para venda de livros digitais(e - book)
            //Com o intuito de fazer um estudo prévio você ficou responsável por identificar
            //as classes relacionadas aos seguintes processos:
            //1.O cliente encontra um e-book e então o coloca num carrinho de compras
            //2.Conforme o cliente informa outros e - books, estes devem ser adicionados ao carrinho de compras
            //3.Ao finalizar a compra o cliente deve informar como quer obter seu e-book, as opções são:
            //download ou e - mail
            //4.Se o cliente não possuir cadastro, o mesmo deve ser realizado na finalização da compra
            //5.O cliente pode ser uma pessoa física ou jurídica, caso seja uma pessoa jurídica será necessário
            //cadastrar também o nome e telefone de uma pessoa para contato

            Cliente cliente1 = new Cliente();
            Livro livro1 = new Livro();

            cliente1.NomeCliente = "Gilbert";
            cliente1.IdadeCliente = 42;
            cliente1.SexoCliente = 'm';
            cliente1.NumeroCartaoCliente = 1234567891;
            cliente1.SaldoCliente = 0;
            cliente1.PontosFidelidadeCliente = 0;
            cliente1.FisicaOuJuridicaCliente = 'f';

            livro1.NomeLivro = "Viajem ao Centro da Terra";
            livro1.GeneroLivro = "Aventura";
            livro1.PrecoLivro = 79.99;

            cliente1.AdicionarLivro(livro1);

            int i = 0;

            //aqui só quis testar se o nome do cliente foi recebido pela variável
            Console.WriteLine("Cliente: " + cliente1.NomeCliente);

            //este "for loop" foi feito para testar os outputs. Como só criei um objeto da classe Livro e outro da
            //classe Cliente, ele só roda uma vez
            for (i = 0; i < 1; i++)
            {
                

                Console.WriteLine("E-Books no carrinho de compras:");
                Console.WriteLine("Título: " + livro1.NomeLivro);
                Console.WriteLine("Gênero: " + livro1.GeneroLivro);
                Console.WriteLine("Preço: " + livro1.PrecoLivro);
            }

            Console.ReadLine();

            //O comando "Pagar()" terminaria a transação
        }
    }
}
