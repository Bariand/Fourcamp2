using System;

namespace Constructors3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 03
            //Escreva uma classe chamada Data que contenha três atributos do tipo int chamados dia, mes e ano
            //a) Crie um método construtor que inicialize os dados com zero e outro método construtor que
            //inicialize os dados com os valores recebidos como parâmetros.
            //b) Crie um método para retornar a data como string no formato: dd / mm / aaaa
            //c) Crie a validação do dia.Ele deve estar entre 1 e 31.Caso contrário inicializar o atributo com o valor 1.
            //d) Crie a validação do mês.Ele deve estar entre 1 e 12.Caso contrário inicializar o atributo com 1.
            //e) Crie a validação do ano.Ele não deve ser negativo. Se o ano for inválido, defina o valor do atributo
            //ano com o ano corrente.
            //f) Crie um método que retorne o nome do mês de acordo com o número que está armazenado no
            //atributo mes.

            Data data = new Data(27, 04, 1985);

            string dataInserida = data.ReturnData(27, 04, 1985);
            Console.WriteLine(dataInserida);
            Console.ReadLine();
        }
    }
}
