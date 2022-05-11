using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors3
{
    public class Data
    {
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

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        string stringMes;
        public Data() 
        {
            Dia = 0;
            Mes = 0;
            Ano = 0;
        }

        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano= ano;
        }

        public string ReturnData(int dia, int mes, int ano)
        {
            if(dia > 31 || dia < 1)
            {
                dia = 1;
            }
            if (mes > 12 || mes < 1)
            {
                mes = 1;
            }
            if (ano < 0)
            {
                ano = 2022;
            }

            switch (mes)
            {
                case 1: 
                    stringMes = "Janeiro";
                    break;
                case 2:
                    stringMes = "Fevereiro";
                    break;
                case 3:
                    stringMes = "Março";
                    break;
                case 4:
                    stringMes = "Abril";
                    break;
                case 5:
                    stringMes = "Maio";
                    break;
                case 6:
                    stringMes = "Junho";
                    break;
                case 7:
                    stringMes = "Julho";
                    break;
                case 8:
                    stringMes = "Agosto";
                    break;
                case 9:
                    stringMes = "Setembro";
                    break;
                case 10:
                    stringMes = "Outubro";
                    break;
                case 11:
                    stringMes = "Novembro";
                    break;
                case 12:
                    stringMes = "Dezembro";
                    break;
            }

            return (string)(dia + "/" + stringMes + "/" + ano);
        }
    }
}
