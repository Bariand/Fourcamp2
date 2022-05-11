using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Elevador
    {
        /*
            Exercício 02
            Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A 
            classe deve armazenar o andar atual (0=térreo), total de andares no prédio, excluindo o térreo, capacidade do 
            elevador (em pessoas), e quantas pessoas estão presentes nele.
            A classe deve também disponibilizar os seguintes métodos: 
            Inicializa: que deve receber como parâmetros: a capacidade do elevador e o total de andares no prédio 
            Entra: para acrescentar uma pessoa no elevador 
            Sai: para remover uma pessoa do elevador 
            Sobe: para subir um andar
            Desce: para descer um andar
            */

        public int AndarTotal { get; set; }
        public int CapacidadeTotal { get; set; }
        public int Andar { get; set; }
        public int CapacidadeEmUtilizacao { get; set; }

        public void Inicializa(int capacidadeTotal, int andarTotal)
        {
            Console.WriteLine("Inicialização concluída.");
            Console.WriteLine("................................................");
            Console.WriteLine("A capacidade total deste elevador é de " + capacidadeTotal + " pessoas;");
            Console.WriteLine("O total de andares definito para este equipamento é de " + andarTotal + " andares, descontando o térreo;");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadLine();
        }

        public int Entra()
        {
            return CapacidadeEmUtilizacao += 1;
        }

        public int Sai()
        {
            return CapacidadeEmUtilizacao -= 1;
        }

        public int Sobe()
        {
            return Andar += 1;
        }

        public int Desce()
        {
            return Andar -= 1;
        }
    }
}
